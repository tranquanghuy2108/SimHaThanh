using Commons.Helper;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Repositories.Implement
{
    public class CollaboratorsGroupRepository : ICollaboratorsGroupRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;
        public CollaboratorsGroupRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }
        public ResponseDataModel<string> Approved(CollaboratorsGroupApprovedRequestModels request)
        {
            try
            {
                if (request.requestIds.Count == 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Bạn chưa nhập yêu cầu approved.",
                    };
                }
                if (request.IsApproved)
                {
                    foreach (var requestId in request.requestIds)
                    {
                        var joinRequest = _context.CollaboratorsGroupJoinRequests.FirstOrDefault(x => x.Id == requestId);
                        joinRequest.Status = Commons.Enums.ApprovedStatus.Approved;
                        _context.CollaboratorsGroupJoinRequests.Update(joinRequest);
                        CollaboratorsGroupUser newUser = new()
                        {
                            UserId = joinRequest.UserId,
                            CollaboratorsGroupId = joinRequest.CollaboratorsGroupId
                        };
                        _context.CollaboratorsGroupUsers.Add(newUser);
                    }
                }
                else
                {
                    foreach (var requestId in request.requestIds)
                    {
                        var joinRequest = _context.CollaboratorsGroupJoinRequests.FirstOrDefault(x => x.Id == requestId);
                        joinRequest.Status = Commons.Enums.ApprovedStatus.Reject;
                        _context.CollaboratorsGroupJoinRequests.Update(joinRequest);
                    }
                }

                _context.SaveChanges();

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Approved yêu cầu vào nhóm KH/Đại lý thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình approved yêu cầu vào nhóm KH/Đại lý.",
                };
            }
        }

        public ResponseDataModel<string> Create(CollaboratorsGroupEditModels request)
        {
            try
            {
                var dataChecking = _context.CollaboratorsGroups.FirstOrDefault(x => x.Name == request.Name);
                if (dataChecking != null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Nhóm KH/Đại lý đã tồn tại.",
                    };

                string collaboratorsGroupCode = string.Empty;
                while (true)
                {
                    collaboratorsGroupCode = OtherHelper.RandomDigits(10);
                    var checkDigit = _context.CollaboratorsGroups.FirstOrDefault(x => x.Code == collaboratorsGroupCode);
                    if (checkDigit == null) break;
                }

                CollaboratorsGroup newData = new()
                {
                    Name = request.Name,
                    CreateBy = request.OwnerId,
                    CreateTime = DateTime.Now,
                    UpdateBy = request.OwnerId,
                    UpdateTime = DateTime.Now,
                    OwnerId = request.OwnerId,
                    IsForAgent = request.IsForAgent,
                    IsApp = request.IsApp,
                    Code = collaboratorsGroupCode,

                };

                _context.CollaboratorsGroups.Add(newData);
                _context.SaveChanges();
                if (request.discount.Count > 0)
                {
                    foreach (var item in request.discount)
                    {
                        _context.Discounts.Add(new Discount()
                        {
                            CollaboratorsGroupId = newData.Id,
                            PriceFrom = item.PriceFrom,
                            PriceTo = item.PriceTo,
                            DiscountPer = item.DiscountPer,
                            CreateBy = request.OwnerId,
                            CreateTime = DateTime.Now,
                            UpdateBy = request.OwnerId,
                            UpdateTime = DateTime.Now,
                        });
                    }
                    _context.SaveChanges();
                }

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Tạo mới nhóm KH/Đại lý thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo mới nhóm KH/Đại lý.",
                };
            }
        }

        public ResponseDataModel<string> Delete(int Id)
        {
            try
            {
                var dataEntity = _context.CollaboratorsGroups.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                var dataCollaboratorsGroupUser = _context.CollaboratorsGroupUsers.Where(x => x.CollaboratorsGroupId == Id);

                _context.CollaboratorsGroupUsers.RemoveRange(dataCollaboratorsGroupUser);
                _context.CollaboratorsGroups.Remove(dataEntity);
                _context.SaveChanges();

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa dữ liệu thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> Edit(CollaboratorsGroupEditModels request)
        {
            try
            {
                var dataUpdate = _context.CollaboratorsGroups.FirstOrDefault(x => x.Id == request.Id);
                if (dataUpdate == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Nhóm KH/Đại lý không tồn tại.",
                    };

                dataUpdate.Name = request.Name;
                dataUpdate.UpdateBy = request.OwnerId;
                dataUpdate.UpdateTime = DateTime.Now;
                dataUpdate.OwnerId = request.OwnerId;
                dataUpdate.IsForAgent = request.IsForAgent;
                dataUpdate.IsApp = request.IsApp;
                _context.CollaboratorsGroups.Update(dataUpdate);
                var listDiscountOld = _context.Discounts.Where(x => x.CollaboratorsGroupId == request.Id).ToList();
                _context.Discounts.RemoveRange(listDiscountOld);
                _context.SaveChanges();
                if (request.discount.Count > 0)
                {
                    foreach (var item in request.discount)
                    {
                        _context.Discounts.Add(new Discount()
                        {
                            CollaboratorsGroupId = dataUpdate.Id,
                            PriceFrom = item.PriceFrom,
                            PriceTo = item.PriceTo,
                            DiscountPer = item.DiscountPer,
                            CreateBy = request.OwnerId,
                            CreateTime = DateTime.Now,
                            UpdateBy = request.OwnerId,
                            UpdateTime = DateTime.Now,
                        });
                    }
                    _context.SaveChanges();
                }

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Cập nhật nhóm KH/Đại lý thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình Cập nhật nhóm KH/Đại lý.",
                };
            }
        }

        public ResponseDataPagingModel<CollaboratorsGroupViewModels> GetAgentGroup(GetPagingRequest request)
        {
            ResponseDataPagingModel<CollaboratorsGroupViewModels> result = new ResponseDataPagingModel<CollaboratorsGroupViewModels>();
            List<CollaboratorsGroupViewModels> data = new List<CollaboratorsGroupViewModels>();
            var agentGroups = _context.CollaboratorsGroups.Where(x => x.Name.Contains(request.keyword)).ToList();
            var idx = 0;
            foreach (var agentGroup in agentGroups)
            {
                idx++;
                var discounts = _context.Discounts.Where(x => x.CollaboratorsGroupId == agentGroup.Id).ToList();
                List<DiscountModel> discountData = new();
                foreach (var discount in discounts)
                {
                    discountData.Add(new()
                    {
                        Id = discount.Id,
                        PriceFrom = discount.PriceFrom,
                        PriceTo = discount.PriceTo,
                        Description = discount.Description,
                        DiscountPer = discount.DiscountPer,
                    });
                }

                data.Add(new CollaboratorsGroupViewModels()
                {
                    Id = agentGroup.Id,
                    Name = agentGroup.Name,
                    Code = agentGroup.Code,
                    discount = discountData,
                    Description = agentGroup.Description
                });
            }
            result = new()
            {
                Code = "1",
                Message = "",
                Data = data,
                Pager = new Pager(new PagingRequestBase() { keyword = request.keyword, pageIndex = 1, pageSize = request.pageSize }, agentGroups.Count()),
            };
            return result;
        }

        public List<SelectListItem> GetAgentGroupsForCombo(bool isForAgent = false)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var agentGroups = _context.CollaboratorsGroups.Where(x => x.IsForAgent == isForAgent && x.IsApp != true).ToList();
            foreach (var item in agentGroups)
            {
                list.Add(new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.Id.ToString(),
                });
            }

            return list;
        }

        public CollaboratorsGroupEditModels GetGroupById(int Id)
        {
            CollaboratorsGroupEditModels data = new CollaboratorsGroupEditModels();
            var dataEntity = _context.CollaboratorsGroups.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                data.Id = dataEntity.Id;
                data.Code = dataEntity.Code;
                data.IsForAgent = dataEntity.IsForAgent;
                data.Name = dataEntity.Name;
                data.OwnerId = dataEntity.OwnerId;
                data.Description = dataEntity.Description;
                data.discount = new();
                var discounts = _context.Discounts.Where(x => x.CollaboratorsGroupId == Id).ToList();
                foreach (var discount in discounts)
                {
                    data.discount.Add(new DiscountModel()
                    {
                        Id = discount.Id,
                        PriceFrom = discount.PriceFrom,
                        PriceTo = discount.PriceTo,
                        DiscountPer = discount.DiscountPer,
                        Description = discount.Description,
                    });
                }
            }
            return data;
        }

        public ResponseDataPagingModel<CollaboratorsGroupViewModels> GetGroupHadJoin(Guid userId)
        {
            var dataEntity = _context.CollaboratorsGroupUsers.Where(x => x.UserId == userId).ToList();
            var data = new List<CollaboratorsGroupViewModels>();
            foreach (var item in dataEntity)
            {
                var collaboratorsGroup = _context.CollaboratorsGroups.FirstOrDefault(x => x.Id == item.CollaboratorsGroupId);
                if (!collaboratorsGroup.IsApp) { continue; }

                var userInfo = _context.Users.FirstOrDefault(x => x.Id == collaboratorsGroup.OwnerId);
                var discounts = _context.Discounts.Where(x => x.CollaboratorsGroupId == item.CollaboratorsGroupId).ToList();
                List<DiscountModel> discountData = new();
                foreach (var discount in discounts)
                {
                    discountData.Add(new()
                    {
                        Id = discount.Id,
                        PriceFrom = discount.PriceFrom,
                        PriceTo = discount.PriceTo,
                        Description = discount.Description,
                        DiscountPer = discount.DiscountPer,
                    });
                }
                data.Add(new CollaboratorsGroupViewModels()
                {
                    Code = collaboratorsGroup?.Code,
                    discount = discountData,
                    Name = collaboratorsGroup.Name,
                    Id = collaboratorsGroup.Id,
                    Owner = userInfo?.FullName
                });
            }
            //
            return new ResponseDataPagingModel<CollaboratorsGroupViewModels>()
            {
                Code = "1",
                Message = "Success",
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = 1, pageSize = data.Count() }, dataEntity.Count()),
                Data = data
            };
        }

        public ResponseDataPagingModel<CollaboratorsGroupMemberModel> GetMemberInGroup(int groupId)
        {
            var dataEntity = _context.CollaboratorsGroupUsers.Where(x => x.CollaboratorsGroupId == groupId).ToList();
            var collaboratorsGroup = _context.CollaboratorsGroups.FirstOrDefault(x => x.Id == groupId);
            var data = new List<CollaboratorsGroupMemberModel>();
            foreach (var item in dataEntity)
            {
                var userInfo = _context.Users.FirstOrDefault(x => x.Id == item.UserId);
                data.Add(new CollaboratorsGroupMemberModel()
                {
                    MemberGroup = collaboratorsGroup.Name,
                    MemberId = item.UserId,
                    MemberName = userInfo.FullName,
                    MemberPhoneNumber = userInfo.PhoneNumber,
                });
            }
            //
            return new ResponseDataPagingModel<CollaboratorsGroupMemberModel>()
            {
                Code = "1",
                Message = "Success",
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = 1, pageSize = data.Count() }, dataEntity.Count()),
                Data = data
            };
        }

        public ResponseDataPagingModel<CollaboratorsGroupMemberModel> GetMemberRequest(Guid userId)
        {
            var collaboratorsGroupOfUserIds = _context.CollaboratorsGroups.Where(x => x.OwnerId == userId).Select(x => x.Id).ToList();

            var dataEntity = _context.CollaboratorsGroupJoinRequests.Where(x => collaboratorsGroupOfUserIds.Contains(x.CollaboratorsGroupId)
                            && x.Status == Commons.Enums.ApprovedStatus.Waiting).ToList();
            var data = new List<CollaboratorsGroupMemberModel>();
            foreach (var item in dataEntity)
            {
                var userInfo = _context.Users.FirstOrDefault(x => x.Id == item.UserId);
                data.Add(new CollaboratorsGroupMemberModel()
                {
                    requesId = item.Id,
                    MemberId = item.UserId,
                    MemberName = userInfo.FullName,
                    MemberPhoneNumber = userInfo.PhoneNumber,
                });
            }
            //
            return new ResponseDataPagingModel<CollaboratorsGroupMemberModel>()
            {
                Code = "1",
                Message = "Success",
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = 1, pageSize = data.Count() }, dataEntity.Count()),
                Data = data
            };
        }

        public ResponseDataPagingModel<CollaboratorsGroupViewModels> GetMyGroup(Guid userId)
        {
            var dataEntity = _context.CollaboratorsGroups.Where(x => x.OwnerId == userId).ToList();
            var userInfo = _context.Users.FirstOrDefault(x => x.Id == userId);
            var data = new List<CollaboratorsGroupViewModels>();
            foreach (var item in dataEntity)
            {
                var discounts = _context.Discounts.Where(x => x.CollaboratorsGroupId == item.Id).ToList();
                List<DiscountModel> discountData = new();
                foreach (var discount in discounts)
                {
                    discountData.Add(new()
                    {
                        Id = discount.Id,
                        PriceFrom = discount.PriceFrom,
                        PriceTo = discount.PriceTo,
                        Description = discount.Description,
                        DiscountPer = discount.DiscountPer,
                    });
                }
                data.Add(new CollaboratorsGroupViewModels()
                {
                    Code = item.Code,
                    discount = discountData,
                    Name = item.Name,
                    Id = item.Id,
                    Owner = userInfo?.FullName
                });
            }
            //
            return new ResponseDataPagingModel<CollaboratorsGroupViewModels>()
            {
                Code = "1",
                Message = "Success",
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = 1, pageSize = data.Count() }, dataEntity.Count()),
                Data = data
            };
        }

        public ResponseDataModel<string> RequestJoin(CollaboratorsGroupJoinRequestModels request)
        {
            try
            {
                var dataChecking = _context.CollaboratorsGroupJoinRequests.FirstOrDefault(x => x.UserId == request.userId
                            && x.CollaboratorsGroupCode == request.Code
                            && x.Status != Commons.Enums.ApprovedStatus.Reject
                            );
                if (dataChecking != null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Yêu cầu tham gia nhóm KH/Đại lý đã tồn tại.",
                    };
                var collaboratorsGroup = _context.CollaboratorsGroups.FirstOrDefault(x => x.Code == request.Code);
                if (collaboratorsGroup == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Mã nhóm KH/Đại lý không tồn tại.",
                    };
                }
                else
                {
                    CollaboratorsGroupJoinRequest newData = new()
                    {
                        UserId = request.userId,
                        CreateBy = request.userId,
                        CreateTime = DateTime.Now,
                        UpdateBy = request.userId,
                        UpdateTime = DateTime.Now,
                        CollaboratorsGroupCode = request.Code,
                        CollaboratorsGroupId = collaboratorsGroup.Id,
                        Status = Commons.Enums.ApprovedStatus.Waiting
                    };

                    _context.CollaboratorsGroupJoinRequests.Add(newData);
                    _context.SaveChanges();

                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Tạo mới yêu cầu vào nhóm KH/Đại lý thành công.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình yêu cầu vào nhóm KH/Đại lý.",
                };
            }
        }
    }
}
