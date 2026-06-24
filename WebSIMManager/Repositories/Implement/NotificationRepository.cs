using Commons.Enums;
using Commons.Helper;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Repositories.Interface;

namespace Repositories.Implement
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;
        public NotificationRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }
        public ResponseDataViewModel<NotificationModel> GetNotificationByUser(Guid userId)
        {
            List<NotificationModel> data = new();
            var query = from noti in _context.Notifications
                        join notiUser in _context.NotificationUsers on noti.Id equals notiUser.NotificationId
                        where notiUser.UserId == userId
                        orderby noti.CreateTime descending
                        select new { noti, notiUser };
            foreach (var item in query)
            {
                data.Add(new NotificationModel
                {
                    Id = item.notiUser.Id,
                    Title = item.noti.Title,
                    Content = item.noti.Content,
                    ImageUrl = item.noti.ImageUrl,
                    CollaboratorsGroupId = item.noti.CollaboratorsGroupId ?? 0,
                    IsRead = item.notiUser.IsRead
                });
            }

            return new ResponseDataViewModel<NotificationModel>
            {
                Pager = new(),
                Data = data,
            };
        }

        public ResponseDataViewModel<NotificationViewModel> GetNotification(GetPagingRequest request)
        {
            if (request.keyword == null) request.keyword = "";
            var query = from noti in _context.Notifications
                        where noti.Title.Contains(request.keyword)
                        orderby noti.CreateTime descending
                        select noti;


            var dataPaging = query.Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).ToList();
            var data = new List<NotificationViewModel>();
            int idx = 0;
            foreach (var item in dataPaging)
            {
                idx++;
                var collaboratorsGroup = "";
                var collab = _context.CollaboratorsGroups.FirstOrDefault(i => i.Id == item.CollaboratorsGroupId);
                if (collab != null)
                {
                    collaboratorsGroup = collab.Name;
                }
                data.Add(new NotificationViewModel()
                {
                    Stt = idx * request.pageIndex,
                    Id = item.Id,
                    Title = item.Title,
                    Content = item.Content,
                    ImageUrl = item.ImageUrl,
                    CollaboratorsGroup = collaboratorsGroup
                });
            }

            //
            return new ResponseDataViewModel<NotificationViewModel>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = request.pageIndex, pageSize = request.pageSize }, query.Count()),
                Data = data
            };
        }

        public ResponseDataModel<string> Create(NotificationModel request, Guid userId)
        {
            try
            {
                var dataChecking = _context.Notifications.FirstOrDefault(x => x.Title == request.Title);
                if (dataChecking != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu đã tồn tại",
                    };
                }

                //Create bew data
                var dataNew = new Notification()
                {
                    Title = request.Title,
                    Content = request.Content,
                    CollaboratorsGroupId = request.CollaboratorsGroupId,
                    ImageUrl = "",
                    CreateBy = userId,
                    UpdateBy = userId,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.Notifications.Add(dataNew);
                var result = _context.SaveChanges();

                if (request.CollaboratorsGroupId == 0)
                {
                    var userIds = _context.Users.Where(x => x.IsStaff != true).Select(x => x.Id).ToList();
                    foreach (var uId in userIds)
                    {
                        var notiUser = new NotificationUser()
                        {
                            NotificationId = dataNew.Id,
                            UserId = uId,
                            IsRead = false,
                            CreateBy = userId,
                            UpdateBy = userId,
                            CreateTime = DateTime.Now,
                            UpdateTime = DateTime.Now,
                        };
                        _context.NotificationUsers.Add(notiUser);
                        _context.SaveChanges();
                    }
                }
                else
                {
                    var userIdsInCollabGroup = _context.CollaboratorsGroupUsers.Where(x => x.CollaboratorsGroupId == request.CollaboratorsGroupId).Select(x => x.UserId).ToList();
                    var userIds = _context.Users.Where(x => x.IsStaff != true && userIdsInCollabGroup.Contains(x.Id)).Select(x => x.Id).ToList();
                    foreach (var uId in userIds)
                    {
                        var notiUser = new NotificationUser()
                        {
                            NotificationId = dataNew.Id,
                            UserId = uId,
                            IsRead = false,
                            CreateBy = userId,
                            UpdateBy = userId,
                            CreateTime = DateTime.Now,
                            UpdateTime = DateTime.Now,
                        };
                        _context.NotificationUsers.Add(notiUser);
                        _context.SaveChanges();
                    }
                }

                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo dữ liệu.",
                };
            }
        }

        public NotificationModel Detail(int Id)
        {
            NotificationModel data = new();
            var dataEntity = _context.Notifications.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                data.Id = dataEntity.Id;
                data.Title = dataEntity.Title;
                data.Content = dataEntity.Content;
                data.ImageUrl = dataEntity.ImageUrl;
                data.CollaboratorsGroupId = dataEntity.CollaboratorsGroupId;
            }
            return data;
        }

        public ResponseDataModel<string> Update(NotificationModel request, Guid userId)
        {
            try
            {
                var dataEntity = _context.Notifications.FirstOrDefault(x => x.Title == request.Title);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại",
                    };
                }

                //
                dataEntity.Title = request.Title;
                dataEntity.Content = request.Content;
                dataEntity.CollaboratorsGroupId = request.CollaboratorsGroupId;
                dataEntity.ImageUrl = "";
                dataEntity.UpdateBy = userId;
                dataEntity.UpdateTime = DateTime.Now;


                _context.Notifications.Update(dataEntity);
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
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật dữ liệu.",
                };
            }
        }
        public ResponseDataModel<string> ReadNotification(ReadNotification request)
        {
            try
            {
                if (request.Ids.Count > 0)
                {
                    var dataEntity = _context.NotificationUsers.Where(x => request.Ids.Contains(x.Id)).ToList(); 
                    foreach (var item in dataEntity)
                    {
                        item.IsRead = true;
                        item.UpdateBy = request.userId;
                        item.UpdateTime = DateTime.Now;
                    }
                    _context.NotificationUsers.UpdateRange(dataEntity);
                    _context.SaveChanges();
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Cập nhật thành công.",
                    };
                }
                else
                {
                    var dataEntity = _context.NotificationUsers.Where(x => x.UserId == request.userId && x.IsRead != true).ToList();
                    foreach(var item in dataEntity)
                    {
                        item.IsRead = true;
                        item.UpdateBy = request.userId;
                        item.UpdateTime = DateTime.Now;
                    }
                    _context.NotificationUsers.UpdateRange(dataEntity);
                    _context.SaveChanges();
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Cập nhật thành công.",
                    };
                }
                
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> Delete(int Id, Guid userId)
        {
            try
            {
                var dataEntity = _context.Notifications.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                _context.Notifications.Remove(dataEntity);
                _context.SaveChanges();

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa thành công.",
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
    }
}
