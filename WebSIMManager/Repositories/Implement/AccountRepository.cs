using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using MySqlConnector;
using Newtonsoft.Json.Linq;
using Repositories.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Net.WebSockets;
using System.Security.Claims;
using System.Text;

namespace Repositories.Implement
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _config;
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;
        public AccountRepository(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IConfiguration config, SIMCenterDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
            _context = context;
            _logAction = new(context);
        }

        public async Task<ResponseDataModel<UserInfoAPIModels>> AuthenticateAPI(LoginRequest request, bool isCMS = true)
        {
            ResponseDataModel<UserInfoAPIModels> responseData = new();
            try
            {
                UserInfoAPIModels userInfo = new();
                AppUser? user;

                if (request.Username.Contains('@'))
                {
                    user = await _userManager.FindByEmailAsync(request.Username);
                }
                else
                {
                    user = await _userManager.FindByNameAsync(request.Username);
                }
                if (user == null || user.IsStaff != isCMS)
                {
                    responseData.Code = "-1";
                    responseData.Message = "Đăng nhập không thành công!";
                    return responseData;
                }

                var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
                if (result.Succeeded)
                {
                    var issuer = _config["Settings:Issuer"];
                    var audience = _config["Settings:Audience"];
                    var key = Encoding.ASCII.GetBytes(_config["Settings:Key"]);
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new[]
                        {
                            new Claim("Id", user.Id.ToString()),
                            new Claim(JwtRegisteredClaimNames.Sub, user.UserName??""),
                            new Claim(JwtRegisteredClaimNames.Email, user.Email??""),
                            new Claim(JwtRegisteredClaimNames.Jti,
                            Guid.NewGuid().ToString())
                         }),
                        Expires = DateTime.UtcNow.AddHours(720),
                        Issuer = issuer,
                        Audience = audience,
                        SigningCredentials = new SigningCredentials
                        (new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha512Signature)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    var jwtToken = tokenHandler.WriteToken(token);
                    var stringToken = tokenHandler.WriteToken(token);

                    //Select data with join
                    //var query = from u in _context.Users
                    //            join ug in _context.UserGroups on u.Id equals ug.UserId
                    //            join 
                    //            select new { u, r };

                    //
                    userInfo.Id = user.Id;
                    userInfo.Username = user.UserName;
                    userInfo.FirstName = "";
                    userInfo.LastName = "";
                    userInfo.FullName = user.FullName;
                    userInfo.Email = user.Email;
                    userInfo.Address = user.Address ?? "";
                    userInfo.PhoneNumber = user.Email;
                    userInfo.Remark = user.Remark;
                    userInfo.Avatar = user.Avatar;
                    userInfo.IsAgent = user.IsAgent;
                    userInfo.Token = stringToken;

                    var roleLst = (from ur in _context.UserRoles
                                   join r in _context.Roles on ur.RoleId equals r.Id
                                   where ur.UserId == user.Id
                                   select r.Name).ToList();
                    if (roleLst.Count > 0) userInfo.Role = String.Join(",", roleLst);
                    else userInfo.Role = "";
                    //
                    var agentOfUser = _context.CollaboratorsGroupUsers.FirstOrDefault(x => x.UserId == user.Id);
                    if (agentOfUser != null)
                    {
                        var agent = _context.CollaboratorsGroups.FirstOrDefault(x => x.Id == agentOfUser.CollaboratorsGroupId);
                        if (agent != null)
                        {
                            userInfo.AgentID = agent.Id;
                            userInfo.AgentName = agent.Name;
                            var discounts = _context.Discounts.Where(x => x.CollaboratorsGroupId == agent.Id).ToList();
                            userInfo.Discount = new();
                            foreach (var item in discounts)
                            {
                                DiscountModel discountModel = new DiscountModel();
                                discountModel.Id = item.Id;
                                discountModel.PriceFrom = item.PriceFrom;
                                discountModel.PriceTo = item.PriceTo;
                                discountModel.DiscountPer = item.DiscountPer;
                                discountModel.Description = item.Description;
                                userInfo.Discount.Add(discountModel);
                            }
                        }
                    }

                    //
                    responseData.Code = "1";
                    responseData.Message = "Đăng nhập thành công!";
                    responseData.Data = userInfo;
                    return responseData;
                }
                else if (result.IsLockedOut)
                {
                    responseData.Code = "0";
                    responseData.Message = "Tài khoản của bạn đã bị khóa, liên hệ admin để được hỗ trợ.";
                    return responseData;
                }
                else
                {
                    responseData.Code = "-1";
                    responseData.Message = "Đăng nhập tài khoản không thành công.";
                    return responseData;
                }
            }
            catch (Exception ex)
            {
                responseData.Code = "-1";
                responseData.Message = "Có lỗi trong quá trình đăng nhập!";
                return responseData;
            }
        }
        public async Task<ResponseDataModel<UserInfoModels>> Authenticate(LoginRequest request, bool isCMS = true)
        {
            ResponseDataModel<UserInfoModels> responseData = new();
            try
            {
                AppUser? user;

                if (request.Username.Contains('@'))
                {
                    user = await _userManager.FindByEmailAsync(request.Username);
                }
                else
                {
                    user = await _userManager.FindByNameAsync(request.Username);
                }
                if (user == null || (user.IsStaff != isCMS && user.IsAgent != true))
                {
                    responseData.Code = "-1";
                    responseData.Message = "Đăng nhập không thành công!";
                    return responseData;
                }

                var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
                if (result.Succeeded)
                {
                    var role = await _userManager.GetRolesAsync(user);
                    var claim = new[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                        //new Claim(ClaimTypes.Name, user.UserName.ToString()),
                        //new Claim(ClaimTypes.Surname, user.FullName),
                        //new Claim(ClaimTypes.Email, user.Email),
                        //new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                        new Claim(ClaimTypes.Role, string.Join(";", role))
                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Settings:Key"]));
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_config["Settings:Issuer"],
                        _config["Settings:Issuer"],
                        claim,
                        expires: DateTime.Now.AddDays(1),
                        signingCredentials: creds);

                    //
                    UserInfoModels userInfo = new();

                    userInfo.Id = user.Id;
                    userInfo.Username = user.UserName;
                    userInfo.FirstName = "";
                    userInfo.LastName = "";
                    userInfo.FullName = user.FullName;
                    userInfo.Email = user.Email;
                    userInfo.Address = user.Address ?? "";
                    userInfo.PhoneNumber = user.Email;
                    userInfo.Remark = user.Remark;
                    userInfo.Avatar = user.Avatar;
                    userInfo.IsStaff = user.IsStaff;
                    userInfo.IsAgent = user.IsAgent;
                    userInfo.Token = new JwtSecurityTokenHandler().WriteToken(token);

                    var roleLst = (from ur in _context.UserRoles
                                   join r in _context.Roles on ur.RoleId equals r.Id
                                   where ur.UserId == user.Id
                                   select r.Name).ToList();
                    if (roleLst.Count > 0) userInfo.Role = String.Join(",", roleLst);
                    else userInfo.Role = "";
                    //
                    responseData.Code = "1";
                    responseData.Message = "Đăng nhập thành công!";
                    responseData.Data = userInfo;
                    return responseData;
                }
                else if (result.IsLockedOut)
                {
                    responseData.Code = "0";
                    responseData.Message = "Tài khoản của bạn đã bị khóa, liên hệ admin để được hỗ trợ.";
                    return responseData;
                }
                else
                {
                    responseData.Code = "-1";
                    responseData.Message = "Đăng nhập tài khoản không thành công.";
                    return responseData;
                }
            }
            catch (Exception ex)
            {
                responseData.Code = "-1";
                responseData.Message = "Có lỗi trong quá trình đăng nhập!";
                return responseData;
            }
        }

        public async Task<ResponseDataModel<string>> ChangePassword(ChangePasswordRequest request)
        {
            try
            {
                var user = _signInManager.UserManager.Users.FirstOrDefault(x => x.Id == request.id && x.IsActive);
                if (user == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tài khoản không tồn tại.",
                    };
                }
                //var result = await _signInManager.UserManager.ChangePasswordAsync(user, request.current_user_pass, request.new_user_pass);
                //if (result.Succeeded)
                //{
                //    return new ResponseDataModel<string>()
                //    {
                //        Code = "1",
                //        Message = "Cập nhật thành công.",
                //    };
                //}
                //else
                //{
                //    return new ResponseDataModel<string>()
                //    {
                //        Code = "0",
                //        Message = "Thông tin bạn nhập chưa chính xác.",
                //    };
                //}
                var passCheckResult = await _signInManager.UserManager.CheckPasswordAsync(user, request.current_user_pass);
                if (passCheckResult)
                {
                    var hasher = new PasswordHasher<AppUser>();
                    user.PasswordHash = hasher.HashPassword(null, request.new_user_pass);
                    _context.Users.Update(user);
                    var result = _context.SaveChanges();
                    if (result > 0)
                    {
                        return new ResponseDataModel<string>()
                        {
                            Code = "1",
                            Message = "Cập nhật thành công.",
                        };
                    }
                    else
                    {
                        return new ResponseDataModel<string>()
                        {
                            Code = "0",
                            Message = "Cập nhật mật khẩu thất bại.",
                        };
                    }
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Thông tin bạn nhập chưa chính xác.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật mật khẩu.",
                };
            }

        }

        public Task<bool> ForgotPassword(ForgotPassRequest request)
        {
            throw new NotImplementedException();
        }

        public int GetCountIPLogin(string ip)
        {
            try
            {
                var dataIp = _context.CountIPLogins.Where(x => x.IPLogin == ip).FirstOrDefault();
                if (dataIp == null)
                {
                    var dataIPNew = new CountIPLogin();
                    dataIPNew.IPLogin = ip;
                    dataIPNew.CountLogin = 1;
                    _context.CountIPLogins.Add(dataIPNew);
                }
                else
                {
                    dataIp.CountLogin += 1;
                    _context.CountIPLogins.Update(dataIp);
                }
                _context.SaveChanges();

                return _context.CountIPLogins.Where(x => x.IPLogin == ip).FirstOrDefault().CountLogin;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int ResetCountIPLogin(string ip)
        {
            try
            {
                var dataIp = _context.CountIPLogins.FirstOrDefault(x => x.IPLogin == ip);
                if (dataIp != null)
                {
                    dataIp.CountLogin = 0;
                    _context.CountIPLogins.Update(dataIp);
                }
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        //
        public ResponseDataModel<string> Create(UserCreateRequest request, bool isCMS = true)
        {
            ResponseDataModel<string> result = new ResponseDataModel<string>();
            try
            {
                //
                var dataChecking = _context.Users.Where(x => x.UserName == request.Username).ToList();
                if (dataChecking.Count > 0)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tài khoản đã tồn tại",
                    };
                //Add User
                var hasher = new PasswordHasher<AppUser>();
                var dataEntity = new AppUser()
                {
                    Email = request.Email ?? "",
                    NormalizedEmail = request.Email ?? "",
                    EmailConfirmed = true,
                    UserName = request.Username,
                    NormalizedUserName = request.Username,
                    PasswordHash = hasher.HashPassword(null, request.Password),
                    SecurityStamp = string.Empty,
                    FullName = request.FullName,
                    PhoneNumber = request.PhoneNumber,
                    Address = request.Address,
                    Website = request.Website,
                    Remark = request.Remark,
                    IsAgent = request.IsAgent,
                    IsConsignmentAgent = request.IsConsignmentAgent,
                    IsStaff = isCMS,
                    DiscountForSimSellersId = request.DiscountForSimSellersId,
                    IsActive = true
                };
                _context.Users.Add(dataEntity);
                _context.SaveChanges();
                if (request.GroupId != null)
                {
                    //Add Group
                    _context.UserGroups.Add(new AppUserGroup()
                    {
                        GroupId = request.GroupId ?? 0,
                        UserId = dataEntity.Id
                    });

                    //Add Role
                    var roleIds = _context.RoleGroups.Where(x => x.GroupId == request.GroupId).Select(x => x.RoleId).ToList();
                    foreach (var roleId in roleIds)
                    {
                        _context.UserRoles.Add(new IdentityUserRole<Guid>()
                        {
                            UserId = dataEntity.Id,
                            RoleId = roleId
                        });
                    }
                }
                if (request.AgentGroupId != null)
                {
                    CollaboratorsGroupUser agentUser = new()
                    {
                        UserId = dataEntity.Id,
                        CollaboratorsGroupId = request.AgentGroupId ?? 0
                    };
                    _context.CollaboratorsGroupUsers.Add(agentUser);
                }
                _context.SaveChanges();

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Tạo mới thành công",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo tài khoản.",
                };
            }
        }//
        public ResponseDataModel<string> CreateUserMobile(UserMobileCreateRequest request)
        {
            ResponseDataModel<string> result = new ResponseDataModel<string>();
            try
            {
                //
                var dataChecking = _context.Users.Where(x => x.UserName == request.Username).ToList();
                if (dataChecking.Count > 0)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tài khoản hoặc email đã tồn tại",
                    };
                //Add User
                var hasher = new PasswordHasher<AppUser>();
                var dataEntity = new AppUser()
                {
                    Email = "",
                    NormalizedEmail = "",
                    EmailConfirmed = true,
                    UserName = request.Username,
                    NormalizedUserName = request.Username,
                    PasswordHash = hasher.HashPassword(null, request.Password),
                    SecurityStamp = string.Empty,
                    FullName = request.FullName,
                    PhoneNumber = request.Username,
                    IsStaff = false,
                    IsAgent = false,
                    IsActive = true
                };
                _context.Users.Add(dataEntity);

                _context.SaveChanges();
                //Add Group
                if (request.GroupId != 0)
                {
                    _context.UserGroups.Add(new AppUserGroup()
                    {
                        GroupId = request.GroupId,
                        UserId = dataEntity.Id
                    });

                    //Add Role
                    var roleIds = _context.RoleGroups.Where(x => x.GroupId == request.GroupId).Select(x => x.RoleId).ToList();
                    foreach (var roleId in roleIds)
                    {
                        var _dataRoleUser = new IdentityUserRole<Guid>()
                        {
                            UserId = dataEntity.Id,
                            RoleId = roleId
                        };
                        _context.UserRoles.Add(_dataRoleUser);
                    }
                    _context.SaveChanges();
                }

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Tạo mới thành công",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo tài khoản.",
                };
            }
        }

        public ResponseDataModel<string> Delete(Guid Id, string userId)
        {
            try
            {
                var _dataEntity = _context.Users.Find(Id);
                var userName = _dataEntity.UserName;
                if (_dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tài khoản không tồn tại.",
                    };
                //_dataEntity.IsActive = false;
                _context.Users.Remove(_dataEntity);
                var group = _context.UserGroups.FirstOrDefault(x => x.UserId == Id);
                if (group != null)
                {
                    _context.UserGroups.Remove(group);
                    var roleOld = _context.UserRoles.Where(x => x.UserId == Id);
                    _context.UserRoles.RemoveRange(roleOld);
                }
                _context.SaveChanges();

                var simsOfAgent = _context.SIMDetails.Where(x => x.Owner == Id);
                _context.SIMDetails.RemoveRange(simsOfAgent);
                _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa KH/đại lý " + userName,
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = "",
                    OldData = ""
                };
                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa tài khoản thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa tài khoản.",
                };
            }
        }

        public Task<List<UserViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseDataViewModel<UserViewModel> GetAllPaging(GetPagingRequest request)
        {
            //Select data with join
            var query = from u in _context.Users
                        where u.IsStaff == true && u.UserName.Contains(request.keyword ?? "") && u.IsActive
                        select new { u };

            //filter data with keyword
            //if (!string.IsNullOrEmpty(request.keyword))
            //	query = query.Where(x => x.u.UserName.Contains(request.keyword) || x.u.Email.Contains(request.keyword));

            //Paging
            int totalRecords = query.Count();
            int totalPages = (int)(totalRecords / request.pageSize) + 1;
            var dataPaging = query.Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize).ToList();
            var dataUserView = new List<UserViewModel>();
            foreach (var item in dataPaging)
            {
                var groupLst = (from ug in _context.UserGroups
                                join g in _context.Groups on ug.GroupId equals g.ID
                                where ug.UserId == item.u.Id
                                select g.Name).ToList();
                var groups = string.Empty;
                if (groupLst.Count > 0) groups = String.Join(",", groupLst);

                dataUserView.Add(new UserViewModel
                {
                    Id = item.u.Id,
                    Address = item.u.Address ?? "",
                    Birthday = item.u.Birthday ?? new DateTime(),
                    Email = item.u.Email ?? "",
                    FullName = item.u.FullName ?? "",
                    IsActive = item.u.IsActive,
                    IsStaff = item.u.IsStaff,
                    PhoneNumber = item.u.PhoneNumber ?? "",
                    Remark = item.u.Remark ?? "",
                    Username = item.u.UserName ?? "",
                    Role = groups
                });
            }

            //
            return new ResponseDataViewModel<UserViewModel>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = request.keyword, pageIndex = request.pageIndex, pageSize = request.pageSize }, query.Count()),
                Data = dataUserView
            };
        }

        public ResponseDataModel<UserInfoModels> Update(UserEditRequest request, bool IsApp = false)
        {
            try
            {
                var dataEntity = _context.Users.Find(request.Id);
                if (dataEntity == null)
                    return new ResponseDataModel<UserInfoModels>()
                    {
                        Code = "0",
                        Message = "Tài khoản không tồn tại.",
                    };

                //_dataEntity.UserName = request.Username;
                dataEntity.FullName = request.FullName ?? "";
                dataEntity.PhoneNumber = request.PhoneNumber;
                dataEntity.Website = request.Website;
                dataEntity.Email = request.Email;
                dataEntity.Address = request.Address;
                dataEntity.Avatar = request.Avatar;
                dataEntity.Remark = request.Remark;
                dataEntity.Website = request.Website;
                if (!IsApp)
                {
                    dataEntity.IsAgent = request.IsAgent;
                    dataEntity.IsConsignmentAgent = request.IsConsignmentAgent;
                }
                dataEntity.DiscountForSimSellersId = request.DiscountForSimSellersId;

                _context.Users.Update(dataEntity);
                _context.SaveChanges();
                var group = _context.UserGroups.FirstOrDefault(x => x.UserId == request.Id);
                if (request.GroupId != group?.GroupId)
                {
                    //Remove old role
                    var roleOld = _context.UserRoles.Where(x => x.UserId == request.Id);
                    if (roleOld != null)
                    {
                        _context.UserRoles.RemoveRange(roleOld);
                    }
                    if (group != null)
                    {
                        _context.UserGroups.Remove(group);
                    }
                    if (request.GroupId != 0)
                    {
                        //Add Group
                        _context.UserGroups.Add(new AppUserGroup()
                        {
                            GroupId = request.GroupId ?? 0,
                            UserId = dataEntity.Id
                        });

                        //Add Role
                        var roleIds = _context.RoleGroups.Where(x => x.GroupId == request.GroupId).Select(x => x.RoleId).ToList();
                        foreach (var roleId in roleIds)
                        {
                            _context.UserRoles.Add(new IdentityUserRole<Guid>()
                            {
                                UserId = dataEntity.Id,
                                RoleId = roleId
                            });
                        }
                    }
                    _context.SaveChanges();
                }

                if (request.AgentGroupId != null && request.AgentGroupId != 0)
                {
                    var agentUserData = _context.CollaboratorsGroupUsers.FirstOrDefault(x => x.UserId == request.Id);
                    if (agentUserData != null)
                    {
                        _context.CollaboratorsGroupUsers.Remove(agentUserData);
                    }
                    CollaboratorsGroupUser agentUser = new()
                    {
                        UserId = dataEntity.Id,
                        CollaboratorsGroupId = request.AgentGroupId ?? 0
                    };
                    _context.CollaboratorsGroupUsers.Add(agentUser);
                    _context.SaveChanges();
                }

                //
                UserInfoModels userInfo = new();

                userInfo.Id = dataEntity.Id;
                userInfo.Username = dataEntity.UserName;
                userInfo.FirstName = "";
                userInfo.LastName = "";
                userInfo.FullName = dataEntity.FullName;
                userInfo.Email = dataEntity.Email;
                userInfo.Address = dataEntity.Address ?? "";
                userInfo.PhoneNumber = dataEntity.Email;
                userInfo.Role = dataEntity.Email;
                userInfo.Avatar = dataEntity.Avatar;
                userInfo.Remark = dataEntity.Remark;

                return new ResponseDataModel<UserInfoModels>()
                {
                    Code = "1",
                    Message = "Cập nhật tài khoản thành công.",
                    Data = userInfo
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<UserInfoModels>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật tài khoản.",
                };
            }
        }

        public UserEditRequest GetUserForEdit(Guid Id)
        {
            var result = new UserEditRequest();
            var dataEntity = _context.Users.FirstOrDefault(x => x.Id == Id);
            if (dataEntity == null) return null;

            double oldDebt = 0;
            var debtOfUser = _context.DebtAgents.Where(x => x.AgentId == Id).ToList();
            if (debtOfUser.Count > 0)
            {
                oldDebt = debtOfUser.Sum(x => x.FinalDebt);
            }
            var receiptOfUser = _context.Receipts.Where(x => x.AgentId == Id).ToList();
            if (receiptOfUser.Count > 0)
            {
                oldDebt += receiptOfUser.Sum(x => x.Receivables);
            }

            result.Id = dataEntity.Id;
            result.Username = dataEntity.UserName;
            result.FullName = dataEntity.FullName;
            result.Email = dataEntity.Email;
            result.PhoneNumber = dataEntity.PhoneNumber;
            result.Address = dataEntity.Address;
            result.Avatar = dataEntity.Avatar;
            var group = _context.UserGroups.FirstOrDefault(x => x.UserId == Id);
            if (group != null) result.GroupId = group.GroupId;
            result.Website = dataEntity.Website;
            result.IsActive = dataEntity.IsActive;
            result.IsAgent = dataEntity.IsAgent;
            result.IsConsignmentAgent = dataEntity.IsConsignmentAgent;
            result.DiscountForSimSellersId = dataEntity.DiscountForSimSellersId;
            result.OldDebt = oldDebt;
            result.AgentGroupId = _context.CollaboratorsGroupUsers.FirstOrDefault(x => x.UserId == Id)?.CollaboratorsGroupId;

            return result;
        }

        public UserInfoAPIModels GetUserForApp(Guid Id)
        {
            var result = new UserInfoAPIModels();
            var dataEntity = _context.Users.FirstOrDefault(x => x.Id == Id);
            if (dataEntity == null) return null;
            //
            result.Id = dataEntity.Id;
            result.Username = dataEntity.UserName;
            result.FirstName = "";
            result.LastName = "";
            result.FullName = dataEntity.FullName;
            result.Email = dataEntity.Email;
            result.Address = dataEntity.Address ?? "";
            result.PhoneNumber = dataEntity.Email;
            result.Remark = dataEntity.Remark;
            result.Avatar = dataEntity.Avatar;
            result.IsAgent = dataEntity.IsAgent;

            var roleLst = (from ur in _context.UserRoles
                           join r in _context.Roles on ur.RoleId equals r.Id
                           where ur.UserId == dataEntity.Id
                           select r.Name).ToList();
            if (roleLst.Count > 0) result.Role = String.Join(",", roleLst);
            else result.Role = "";
            //
            var agentOfUser = _context.CollaboratorsGroupUsers.FirstOrDefault(x => x.UserId == dataEntity.Id);
            if (agentOfUser != null)
            {
                var agent = _context.CollaboratorsGroups.FirstOrDefault(x => x.Id == agentOfUser.CollaboratorsGroupId);
                if (agent != null)
                {
                    result.AgentID = agent.Id;
                    result.AgentName = agent.Name;
                    var discounts = _context.Discounts.Where(x => x.CollaboratorsGroupId == agent.Id).ToList();
                    result.Discount = new();
                    foreach (var item in discounts)
                    {
                        DiscountModel discountModel = new DiscountModel();
                        discountModel.Id = item.Id;
                        discountModel.PriceFrom = item.PriceFrom;
                        discountModel.PriceTo = item.PriceTo;
                        discountModel.DiscountPer = item.DiscountPer;
                        discountModel.Description = item.Description;
                        result.Discount.Add(discountModel);
                    }
                }
            }

            return result;
        }

        public List<SelectListItem> GetListAllUserForCombo()
        {
            var result = new List<SelectListItem>();
            var _data = _context.Users.Where(x => x.IsActive).ToList();
            if (_data != null && _data.Count > 0)
            {
                foreach (var item in _data)
                {
                    result.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.UserName });
                }
            }
            return result;
        }

        public ResponseDataViewModel<AgentViewModel> GetAgentList(AgentFilterRequest request)
        {
            //Select data with join
            var query = (from u in _context.Users
                         where u.UserName.Contains(request.agentAcc ?? "") && !u.IsStaff && u.IsAgent && u.IsActive
                         select new { u }).ToList();
            //

            //filter data with agent user
            if (request.agentGroup.Count > 0)
            {
                var userIdsInAgentGroup = _context.CollaboratorsGroupUsers.Where(x => request.agentGroup.Contains(x.CollaboratorsGroupId)).Select(x => x.UserId).ToList();
                query = query.Where(x => userIdsInAgentGroup.Contains(x.u.Id)).ToList();
            }

            //Paging
            int totalRecords = query.Count();
            int totalPages = (int)(totalRecords / request.pageSize) + 1;
            var dataPaging = query.Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize).ToList();
            var dataUserView = new List<AgentViewModel>();
            foreach (var item in dataPaging)
            {
                var agentGroupLst = (from cgu in _context.CollaboratorsGroupUsers
                                     join cg in _context.CollaboratorsGroups on cgu.CollaboratorsGroupId equals cg.Id
                                     where cgu.UserId == item.u.Id
                                     select cg.Name).ToList();
                var groups = string.Empty;
                if (agentGroupLst.Count > 0) groups = String.Join(",", agentGroupLst);
                //var simNum = _context.SIMDetails.Where(x => x.Owner == item.u.Id).Count();
                //Call stored procedure
                FormattableString stored_procedure_query = $"call CountSimOfAgent({item.u.Id})";
                var simNum = 0;
                if (request.isAgent)
                    simNum = _context.Database.SqlQuery<int>(stored_procedure_query).ToList()[0];
                dataUserView.Add(new AgentViewModel
                {
                    Id = item.u.Id,
                    Address = item.u.Address ?? "",
                    Email = item.u.Email ?? "",
                    FullName = item.u.FullName ?? "",
                    PhoneNumber = item.u.PhoneNumber ?? "",
                    Remark = item.u.Remark ?? "",
                    Username = item.u.UserName ?? "",
                    AgentGroup = groups,
                    SimNumber = simNum.ToString()
                });
            }

            //
            return new ResponseDataViewModel<AgentViewModel>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = request.agentAcc ?? "", pageIndex = request.pageIndex, pageSize = request.pageSize }, query.Count()),
                Data = dataUserView
            };
        }

        public ResponseDataViewModel<AgentViewModel> GetConsignmentAgentLst(AgentFilterRequest request)
        {
            //Select data with join
            var query = (from u in _context.Users
                         where u.UserName.Contains(request.agentAcc ?? "") && !u.IsStaff && u.IsConsignmentAgent == true && u.IsActive == true
                         select new { u }).ToList();

            //filter data with agent user
            if (request.agentGroup.Count > 0)
            {
                var userIdsInAgentGroup = _context.CollaboratorsGroupUsers.Where(x => request.agentGroup.Contains(x.CollaboratorsGroupId)).Select(x => x.UserId).ToList();
                query = query.Where(x => userIdsInAgentGroup.Contains(x.u.Id)).ToList();
            }

            //Paging
            int totalRecords = query.Count();
            int totalPages = (int)(totalRecords / request.pageSize) + 1;
            var dataPaging = query.Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize).ToList();
            var dataUserView = new List<AgentViewModel>();
            foreach (var item in dataPaging)
            {
                var agentGroupLst = (from cgu in _context.CollaboratorsGroupUsers
                                     join cg in _context.CollaboratorsGroups on cgu.CollaboratorsGroupId equals cg.Id
                                     where cgu.UserId == item.u.Id
                                     select cg.Name).ToList();
                var groups = string.Empty;
                if (agentGroupLst.Count > 0) groups = String.Join(",", agentGroupLst);
                //var simNum = _context.SIMDetails.Where(x => x.Owner == item.u.Id).Count();
                //Call stored procedure
                FormattableString stored_procedure_query = $"call CountSimOfAgent({item.u.Id})";
                var simNum = 0;
                if (request.isAgent)
                    simNum = _context.Database.SqlQuery<int>(stored_procedure_query).ToList()[0];
                dataUserView.Add(new AgentViewModel
                {
                    Id = item.u.Id,
                    Address = item.u.Address ?? "",
                    Email = item.u.Email ?? "",
                    FullName = item.u.FullName ?? "",
                    PhoneNumber = item.u.PhoneNumber ?? "",
                    Remark = item.u.Remark ?? "",
                    Username = item.u.UserName ?? "",
                    AgentGroup = groups,
                    SimNumber = simNum.ToString()
                });
            }

            //
            return new ResponseDataViewModel<AgentViewModel>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = request.agentAcc ?? "", pageIndex = request.pageIndex, pageSize = request.pageSize }, query.Count()),
                Data = dataUserView
            };
        }

        public ResponseDataViewModel<AgentViewModel> GetCustomerLst(AgentFilterRequest request)
        {
            //Select data with join
            var query = (from u in _context.Users
                         where u.UserName.Contains(request.agentAcc ?? "") && !u.IsStaff && !u.IsConsignmentAgent && !u.IsAgent && u.IsActive
                         select new { u }).ToList();

            //filter data with agent user
            if (request.agentGroup.Count > 0)
            {
                var userIdsInAgentGroup = _context.CollaboratorsGroupUsers.Where(x => request.agentGroup.Contains(x.CollaboratorsGroupId)).Select(x => x.UserId).ToList();
                query = query.Where(x => userIdsInAgentGroup.Contains(x.u.Id)).ToList();
            }

            //Paging
            int totalRecords = query.Count();
            int totalPages = (int)(totalRecords / request.pageSize) + 1;
            var dataPaging = query.Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize).ToList();
            var dataUserView = new List<AgentViewModel>();
            foreach (var item in dataPaging)
            {
                var agentGroupLst = (from cgu in _context.CollaboratorsGroupUsers
                                     join cg in _context.CollaboratorsGroups on cgu.CollaboratorsGroupId equals cg.Id
                                     where cgu.UserId == item.u.Id
                                     select cg.Name).ToList();
                var groups = string.Empty;
                if (agentGroupLst.Count > 0) groups = String.Join(",", agentGroupLst);
                //var simNum = _context.SIMDetails.Where(x => x.Owner == item.u.Id).Count();
                //Call stored procedure
                FormattableString stored_procedure_query = $"call CountSimOfAgent({item.u.Id})";
                var simNum = 0;
                if (request.isAgent)
                    simNum = _context.Database.SqlQuery<int>(stored_procedure_query).ToList()[0];
                dataUserView.Add(new AgentViewModel
                {
                    Id = item.u.Id,
                    Address = item.u.Address ?? "",
                    Email = item.u.Email ?? "",
                    FullName = item.u.FullName ?? "",
                    PhoneNumber = item.u.PhoneNumber ?? "",
                    Remark = item.u.Remark ?? "",
                    Username = item.u.UserName ?? "",
                    AgentGroup = groups,
                    SimNumber = simNum.ToString()
                });
            }

            //
            return new ResponseDataViewModel<AgentViewModel>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = request.agentAcc ?? "", pageIndex = request.pageIndex, pageSize = request.pageSize }, query.Count()),
                Data = dataUserView
            };
        }

        public List<SelectListItem> GetAgentForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.Users.Where(x => x.IsAgent == true && x.IsActive).ToList();
            foreach (var item in data)
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = item.FullName + " (" + item.UserName + ")",
                    Value = item.Id.ToString(),
                });
            }
            return selectListItems;
        }
        public List<SelectListItem> GetAgentConsigmentForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.Users.Where(x => x.IsConsignmentAgent == true && x.IsActive).ToList();
            foreach (var item in data)
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = item.FullName + " (" + item.UserName + ")",
                    Value = item.Id.ToString(),
                });
            }
            return selectListItems;
        }
        public List<SelectListItem> GetAgentAndAgentConsigmentForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.Users.Where(x => (x.IsConsignmentAgent || x.IsAgent) && x.IsActive).ToList();
            foreach (var item in data)
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = item.FullName + " (" + item.UserName + ")",
                    Value = item.Id.ToString(),
                });
            }
            return selectListItems;
        }

        public List<SelectListItem> GetCusAgentForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.Users.Where(x => x.IsActive).ToList();
            foreach (var item in data)
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = item.FullName + " (" + item.UserName + ")",
                    Value = item.Id.ToString(),
                });
            }
            return selectListItems;
        }

        public List<SelectListItem> GetStaffForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.Users.Where(x => x.IsStaff == true && x.IsActive).ToList();
            foreach (var item in data)
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = item.FullName + " (" + item.UserName + ")",
                    Value = item.Id.ToString(),
                });
            }
            return selectListItems;
        }

        public async Task<ResponseDataModel<string>> ResetPasswordAsync(string userId)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                    return new ResponseDataModel<string>
                    {
                        Code = "0",
                        Message = "Thông tin không đúng.",
                        Data = ""
                    };
                string resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                if (string.IsNullOrEmpty(resetToken))
                    return new ResponseDataModel<string>
                    {
                        Code = "0",
                        Message = "Error while generating reset token.",
                        Data = ""
                    };
                var newPassword = Commons.Helper.OtherHelper.GenerateRandomString(10);
                var result = await _userManager.ResetPasswordAsync(user, resetToken, newPassword);
                if (result.Succeeded)
                    return new ResponseDataModel<string>
                    {
                        Code = "1",
                        Message = "Reset password thành công.",
                        Data = "newPassword"
                    };
                else
                    return new ResponseDataModel<string>
                    {
                        Code = "0",
                        Message = "Reset password không thành công.",
                        Data = ""
                    };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>
                {
                    Code = "-1",
                    Message = "Reset password không thành công.",
                    Data = ex.Message
                };
            }
        }
    }
}
