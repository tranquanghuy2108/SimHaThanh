using Commons.CallAPIs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interface;

namespace WebSIMManager.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        private readonly IConfiguration _configuration;
        public MessageController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // GET: MessageController
        public ActionResult Index()
        {
            ViewBag.UserID = _configuration.GetValue<string>("Sendbird:USER_ID");
            return View();
        }

        // GET: MessageController/Details/5

        [Route("get-channel")]
        public async Task<ActionResult> GetGroupChannel()
        {
            //Khởi tạo chat sendbird
            var APP_ID = _configuration.GetValue<string>("Sendbird:APP_ID");
            var USER_ID = _configuration.GetValue<string>("Sendbird:USER_ID");
            var ACCESS_TOKEN = _configuration.GetValue<string>("Sendbird:ACCESS_TOKEN");
            var myGroupChannel = await SendbirdAPI.GetMyGroupChannelAsync(APP_ID, USER_ID, ACCESS_TOKEN);
            return Json(myGroupChannel);
        }
        [Route("get-list-message")]
        public async Task<ActionResult> GetListMessage(string channel_url)
        {
            //Khởi tạo chat sendbird
            var APP_ID = _configuration.GetValue<string>("Sendbird:APP_ID");
            //var USER_ID = _configuration.GetValue<string>("Sendbird:USER_ID");
            var ACCESS_TOKEN = _configuration.GetValue<string>("Sendbird:ACCESS_TOKEN");
            var listMessage = await SendbirdAPI.GetListMessageAsync(APP_ID, channel_url, ACCESS_TOKEN);
            return Json(listMessage);
        }
        [Route("send-message")]
        public async Task<ActionResult> SendMessage(string channel_url, string message)
        {
            //Khởi tạo chat sendbird
            var APP_ID = _configuration.GetValue<string>("Sendbird:APP_ID");
            var USER_ID = _configuration.GetValue<string>("Sendbird:USER_ID");
            var ACCESS_TOKEN = _configuration.GetValue<string>("Sendbird:ACCESS_TOKEN");
            var listMessage = await SendbirdAPI.SendMessageAsync(message, APP_ID, USER_ID, channel_url, ACCESS_TOKEN);
            return Json(listMessage);
        }
        [Route("mask-read-message")]
        public async Task<ActionResult> MaskReadMessage(string channel_url)
        {
            //Khởi tạo chat sendbird
            var APP_ID = _configuration.GetValue<string>("Sendbird:APP_ID");
            var USER_ID = _configuration.GetValue<string>("Sendbird:USER_ID");
            var ACCESS_TOKEN = _configuration.GetValue<string>("Sendbird:ACCESS_TOKEN");
            var response = await SendbirdAPI.MaskReadMessageAsync(APP_ID, ACCESS_TOKEN, channel_url, USER_ID);
            return Json(response);
        }


    }
}
