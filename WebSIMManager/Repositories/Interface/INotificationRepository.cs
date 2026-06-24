using Commons.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface INotificationRepository
    {
        ResponseDataViewModel<NotificationModel> GetNotificationByUser(Guid userId);
        ResponseDataViewModel<NotificationViewModel> GetNotification(GetPagingRequest request);
        ResponseDataModel<string> Create(NotificationModel request, Guid userId);
        ResponseDataModel<string> Update(NotificationModel request, Guid userId);
        NotificationModel Detail(int Id);
        ResponseDataModel<string> Delete(int Id, Guid userId);
        ResponseDataModel<string> ReadNotification(ReadNotification request);
    }
}
