using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Responses;
using Models.ViewModels;
using Repositories.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSIMAPI.Controllers
{
    [Route("api/noti")]
    [ApiController]
    [Authorize]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationRepository _notiRepository;

        public NotificationController(INotificationRepository notiRepository)
        {
            _notiRepository = notiRepository;
        }

        [HttpPost("get-my-noti")]
        public ResponseDataViewModel<NotificationModel> GetNotification([FromBody] Guid userId)
        {
            return _notiRepository.GetNotificationByUser(userId);
        }

        [HttpPost("read-noti")]
        public ResponseDataModel<string> ReadNotification([FromBody] ReadNotification request)
        {
            return _notiRepository.ReadNotification(request);
        }
    }
}
