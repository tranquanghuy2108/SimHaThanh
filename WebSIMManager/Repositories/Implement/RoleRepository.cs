using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Repositories.Interface;

namespace Repositories.Implement
{
    public class RoleRepository : IRoleRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;
        public RoleRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }

        public ResponseDataPagingModel<AppRole> CreateRole(RoleCreate request)
        {
            try
            {
                var dataChecking = _context.Roles.FirstOrDefault(x => x.Name == request.Name);
                if (dataChecking != null)
                {
                    return new ResponseDataPagingModel<AppRole>()
                    {
                        Code = "0",
                        Message = "SIM đã tồn tại",
                    };
                }

                var roleNew = new AppRole()
                {
                    Name = request.Name,
                    NormalizedName = request.Name,
                    Description = request.Description,
                };
                _context.Roles.Add(roleNew);
                int result = _context.SaveChanges();

                if (result > 0)
                {
                    return new ResponseDataPagingModel<AppRole>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                    };
                }
                else
                {
                    return new ResponseDataPagingModel<AppRole>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataPagingModel<AppRole>()
                {
                    Code = "-1",
                    Message = "Tạo mới thất bại." + ex.Message,
                };
            }
        }

        public ResponseDataPagingModel<AppGroup> CreateGroup(AppGroupCreate request)
        {
            try
            {
                var dataChecking = _context.Groups.FirstOrDefault(x => x.Name == request.Name);
                if (dataChecking != null)
                {
                    return new ResponseDataPagingModel<AppGroup>()
                    {
                        Code = "0",
                        Message = "SIM đã tồn tại",
                    };
                }

                var dataNew = new AppGroup()
                {
                    Name = request.Name,
                    Description = request.Description,
                    IsStaffRole = request.IsStaffRole
                };
                _context.Groups.Add(dataNew);
                if (request.RoleIds != null)
                {
                    _context.SaveChanges();
                    //
                    foreach (var roleId in request.RoleIds)
                    {
                        var roleGroup = new AppRoleGroup()
                        {
                            RoleId = roleId,
                            GroupId = dataNew.ID
                        };

                        _context.RoleGroups.Add(roleGroup);
                    }
                }
                int result = _context.SaveChanges();

                if (result > 0)
                {
                    return new ResponseDataPagingModel<AppGroup>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                    };
                }
                else
                {
                    return new ResponseDataPagingModel<AppGroup>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataPagingModel<AppGroup>()
                {
                    Code = "-1",
                    Message = "Tạo mới thất bại." + ex.Message,
                };
            }
        }


        public ResponseDataPagingModel<RoleView> GetRolePaging()
        {
            ResponseDataPagingModel<RoleView> appRoles = new ResponseDataPagingModel<RoleView>();
            List<RoleView> roleViews = new List<RoleView>();
            var data = _context.Roles.ToList();
            var idx = 0;
            foreach (var role in data)
            {
                idx++;
                roleViews.Add(new RoleView()
                {
                    Stt = idx.ToString(),
                    Id = role.Id,
                    Name = role.Name,
                    Description = role.Description
                });
            }
            appRoles = new()
            {
                Code = "0",
                Message = "0",
                Data = roleViews,
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = 1, pageSize = roleViews.Count() }, roleViews.Count()),
            };
            return appRoles;
        }
        public RoleCreate GetRoleById(Guid Id)
        {
            RoleCreate role = new RoleCreate();
            var data = _context.Roles.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                role.Id = data.Id;
                role.Name = data.Name;
                role.Description = data.Description;
            }
            return role;
        }
        public AppGroupCreate GetGroupById(int Id)
        {
            AppGroupCreate group = new AppGroupCreate();
            var data = _context.Groups.FirstOrDefault(x => x.ID == Id);
            if (data != null)
            {
                group.Id = data.ID;
                group.Name = data.Name;
                group.RoleIds = _context.RoleGroups.Where(x => x.GroupId == Id).Select(x => x.RoleId).ToList();
                group.Description = data.Description;
                group.IsStaffRole = data.IsStaffRole;
            }
            return group;
        }
        public ResponseDataPagingModel<RoleGroupView> GetRoleGroupPaging(GetPagingRequest request)
        {
            ResponseDataPagingModel<RoleGroupView> appRoles = new ResponseDataPagingModel<RoleGroupView>();
            var query = from g in _context.Groups
                        where g.Name.Contains(request.keyword)
                        select new { g };
            var pagingData = query.Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).ToList();

            List<RoleGroupView> data = new List<RoleGroupView>();
            int idx = 0;
            foreach (var item in pagingData)
            {
                idx++;

                var roleInGroup = (from rg in _context.RoleGroups
                                   join r in _context.Roles on rg.RoleId equals r.Id
                                   join g in _context.Groups on rg.GroupId equals g.ID
                                   where g.ID.Equals(item.g.ID)
                                   select r.Name).ToList();
                string roleInGroupStr = string.Join(", ", roleInGroup);
                if (roleInGroupStr.Length > 0 && roleInGroupStr.Substring(roleInGroupStr.Length - 2) == ", ")
                    roleInGroupStr = roleInGroupStr.Substring(0, roleInGroupStr.Length - 2);

                data.Add(new RoleGroupView()
                {
                    Id = item.g.ID,
                    GroupName = item.g.Name,
                    RoleInGroup = roleInGroupStr,
                    Description = item.g.Description,
                    Stt = (idx * request.pageIndex).ToString()
                });
            }

            appRoles = new()
            {
                Code = "0",
                Message = "0",
                Data = data,
                Pager = new Pager(new PagingRequestBase() { keyword = request.keyword, pageIndex = request.pageIndex, pageSize = request.pageSize }, query.Count()),
            };

            return appRoles;
        }

        public List<SelectListItem> GetRoleListForCombo(string selectedValue = "")
        {
            if (string.IsNullOrEmpty(selectedValue))
                selectedValue = "A32513B8-6EB4-433D-AF51-CE369BCF4D80";
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var roles = _context.Roles.ToList();
            foreach (var role in roles)
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = role.Name,
                    Value = role.Id.ToString(),
                    Selected = role.Id.ToString().Contains(selectedValue)
                });
            }
            return selectListItems;
        }
        public List<SelectListItem> GetGroupListForCombo(string selectedValue = "", bool isStaffRole = true)
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var groups = _context.Groups.Where(x => x.IsStaffRole == isStaffRole).ToList();
            foreach (var group in groups)
            {
                bool selected = false;
                if (string.IsNullOrEmpty(selectedValue))
                    selected = groups.First() == group;
                else
                    selected = group.ID.ToString().Contains(selectedValue);
                selectListItems.Add(new SelectListItem
                {
                    Text = group.Name,
                    Value = group.ID.ToString(),
                    Selected = selected
                });
            }
            return selectListItems;
        }

        public ResponseDataPagingModel<AppRole> UpdateRole(RoleCreate request)
        {
            try
            {
                var dataEntity = _context.Roles.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataPagingModel<AppRole>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                }

                dataEntity.Name = request.Name;
                dataEntity.Description = request.Description;

                _context.Roles.Update(dataEntity);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataPagingModel<AppRole>()
                    {
                        Code = "1",
                        Message = "Cập nhật thành công.",
                    };
                }
                else
                {
                    return new ResponseDataPagingModel<AppRole>()
                    {
                        Code = "0",
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataPagingModel<AppRole>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật.",
                };
            }
        }

        public ResponseDataPagingModel<AppGroup> UpdateGroup(AppGroupCreate request)
        {
            try
            {
                var dataEntity = _context.Groups.FirstOrDefault(x => x.ID == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataPagingModel<AppGroup>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                }

                dataEntity.Name = request.Name;
                dataEntity.Description = request.Description;
                dataEntity.IsStaffRole = request.IsStaffRole;

                _context.Groups.Update(dataEntity);

                //Delete Old role
                var roleInGroup = _context.RoleGroups.Where(x => x.GroupId == request.Id);
                _context.RoleGroups.RemoveRange(roleInGroup);

                //Add new role in group
                foreach (var roleId in request.RoleIds)
                {
                    var roleGroup = new AppRoleGroup()
                    {
                        RoleId = roleId,
                        GroupId = dataEntity.ID
                    };

                    _context.RoleGroups.Add(roleGroup);
                }

                // update user in role group
                var userIdsInGroup = _context.UserGroups.Where(x => x.GroupId == request.Id).Select(x => x.UserId).ToList();
                if (userIdsInGroup.Count > 0)
                {
                    var oldRoleOfUser = _context.UserRoles.Where(x => userIdsInGroup.Contains(x.UserId));
                    _context.UserRoles.RemoveRange(oldRoleOfUser);
                    foreach (var userId in userIdsInGroup)
                    {
                        foreach (var roleId in request.RoleIds)
                        {
                            _context.UserRoles.Add(new IdentityUserRole<Guid>()
                            {
                                UserId = userId,
                                RoleId = roleId
                            });
                        }
                    }
                }
                int result = _context.SaveChanges();

                //
                if (result > 0)
                {
                    return new ResponseDataPagingModel<AppGroup>()
                    {
                        Code = "1",
                        Message = "Cập nhật thành công.",
                    };
                }
                else
                {
                    return new ResponseDataPagingModel<AppGroup>()
                    {
                        Code = "0",
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataPagingModel<AppGroup>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật.",
                };
            }
        }

        public ResponseDataPagingModel<AppRole> DeleteRole(Guid Id)
        {
            try
            {
                var dataEntity = _context.Roles.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataPagingModel<AppRole>()
                    {
                        Code = "0",
                        Message = "Nhà mạng không tồn tại.",
                    };
                _context.Roles.Remove(dataEntity);
                _context.SaveChanges();

                return new ResponseDataPagingModel<AppRole>()
                {
                    Code = "1",
                    Message = "Xóa nhà mạng thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataPagingModel<AppRole>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa nhà mạng.",
                };
            }
        }

        public ResponseDataPagingModel<AppGroup> DeleteGroup(int Id)
        {
            try
            {
                var dataEntity = _context.Groups.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataPagingModel<AppGroup>()
                    {
                        Code = "0",
                        Message = "Nhà mạng không tồn tại.",
                    };
                _context.Groups.Remove(dataEntity);
                var roleInGroup = _context.RoleGroups.Where(x => x.GroupId == Id);
                _context.RoleGroups.RemoveRange(roleInGroup);
                _context.SaveChanges();

                return new ResponseDataPagingModel<AppGroup>()
                {
                    Code = "1",
                    Message = "Xóa nhà mạng thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataPagingModel<AppGroup>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa nhà mạng.",
                };
            }
        }
    }
}
