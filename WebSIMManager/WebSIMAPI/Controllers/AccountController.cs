using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models.Responses;
using Models.ViewModels;
using Repositories.Implement;
using Repositories.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSIMAPI.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IContactRepository _contactRepository;
        private readonly ISystemConfigRepository _systemConfigRepository;
        private readonly IBankRepository _bankRepository;

        public AccountController(
            IAccountRepository accountRepository,
            IContactRepository contactRepository,
            ISystemConfigRepository systemConfigRepository,
            IBankRepository bankRepository
        )
        {
            _accountRepository = accountRepository;
            _contactRepository = contactRepository;
            _systemConfigRepository = systemConfigRepository;
            _bankRepository = bankRepository;
        }

        [EnableCors("MyPolicy")]
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _accountRepository.AuthenticateAPI(request, isCMS: false);

            if (response.Code != "1")
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        // POST api/<AccountController
        [EnableCors("MyPolicy")]
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(
            [FromBody] UserMobileCreateRequest userCreateRequest
        )
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _accountRepository.CreateUserMobile(userCreateRequest);

            if (result.Code != "1")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        // POST api/<AccountController>
        [EnableCors("MyPolicy")]
        [HttpPost("change-password")]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _accountRepository.ChangePassword(request);

            if (result.Code != "1")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        // POST api/<AccountController>
        [EnableCors("MyPolicy")]
        [HttpPost("update-info")]
        [Authorize]
        public IActionResult UpdateUserInfo([FromBody] UserEditRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _accountRepository.Update(request, true);

            if (result.Code != "1")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        // POST api/<AccountController>
        [EnableCors("MyPolicy")]
        [HttpPost("delete-account")]
        [Authorize]
        public IActionResult UpdateUserInfo([FromBody] Guid userId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _accountRepository.Delete(userId, userId.ToString());

            if (result.Code != "1")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        // POST api/<AccountController>
        [EnableCors("MyPolicy")]
        [HttpPost("get-userinfo")]
        [Authorize]
        public IActionResult GetUserInfo([FromBody] Guid userId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _accountRepository.GetUserForApp(userId);

            return Ok(result);
        }

        [HttpPost("get-spcontact")]
        [Authorize]
        public IActionResult GetSPContact()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _contactRepository.GetSPContactAPI();

            return Ok(result);
        }

        [HttpPost("get-config")]
        [Authorize]
        public IActionResult GetAppSysConfig()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _systemConfigRepository.GetAppSysConfig();

            return Ok(result);
        }

        [HttpPost("get-bankInfo")]
        [Authorize]
        public IActionResult GetBankInfo()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _bankRepository.GetBankForApp();

            return Ok(result);
        }
    }
}
