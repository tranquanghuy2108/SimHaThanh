using Commons.Constants;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Models.ViewModels;
using Newtonsoft.Json;
using Repositories.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using Commons.Sessions;

namespace WebSIMManager.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IConfiguration _configuration;

        public AdminController(IAccountRepository accountRepository, IConfiguration configuration)
        {
            _accountRepository = accountRepository;
            _configuration = configuration;
        }

        [Authorize]
        [Route("admin")]
        public IActionResult Index()
        {
            string ip = Response.HttpContext.Connection.RemoteIpAddress.ToString();
            if (ip == "::1")
            {
                ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
            }
            SessionsData.IPAddress = ip;
            return RedirectToAction("AskSim", "SIMOrder"); ;
        }
        [Route("login")]
        public async Task<IActionResult> Login()
        {
            ViewBag.ShowCaptcha = 0;
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }
        //
        [HttpPost]
        [Route("login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginRequest loginData)
        {
            var sessionID = HttpContext.Session.Id;
            Response.Cookies.Append(".AdventureWorks.Session", sessionID);
            if (!ModelState.IsValid)
            {
                return View(loginData);
            }
            ViewBag.ShowCaptcha = 0;
            var countLogin = _accountRepository.GetCountIPLogin(HttpContext.Connection.RemoteIpAddress.ToString());
            if (countLogin >= 3)
                ViewBag.ShowCaptcha = 1;

            //if (countLogin >= 4)
            //{
            //    if (!CaptchaHelper.ValidateCaptchaCode(loginData.CaptchaCode, HttpContext))
            //    {
            //        ModelState.AddModelError(String.Empty, "Mã captcha bạn nhập không đúng.");
            //        return View(loginData);
            //    }
            //}

            var response = await _accountRepository.Authenticate(loginData);
            if (response.Code == "0")
            {
                ModelState.AddModelError(String.Empty, response.Message ?? "");
                return View(loginData);
            }
            if (response.Code == "-1")
            {
                ViewBag.LoginErr = "";

                ModelState.AddModelError(String.Empty, "Thông tin đăng nhập không đúng.");
                return View(loginData);
            }

            _accountRepository.ResetCountIPLogin(HttpContext.Connection.RemoteIpAddress.ToString());
            var userPrincial = this.ValidateToken(response.Data.Token);

            var autheProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(1),
                IsPersistent = true
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                userPrincial,
                autheProperties);

            HttpContext.Session.SetString(CommonConstants.PERSON_INFO_SESSION, JsonConvert.SerializeObject(response.Data));
            string authId = GenerateAuthId();

            // Store the value in both our Session and a Cookie.
            HttpContext.Session.SetString("AuthId", authId);
            CookieOptions options = new CookieOptions()
            {
                Path = "/",
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict
            };
            Response.Cookies.Append("AuthCookie", authId, options);

            if (response.Data.IsStaff) return RedirectToAction("Index", "Admin");
            else return RedirectToAction("Index", "AppAgent");
        }

        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            if (HttpContext.Request.Cookies.Count > 0)
            {
                var siteCookies = HttpContext.Request.Cookies.Where(c => c.Key.Contains("AspNetCore.") ||
                        c.Key.Contains("Microsoft.Authentication") ||
                        c.Key.Contains("AuthCookie"));
                foreach (var cookie in siteCookies)
                {
                    Response.Cookies.Delete(cookie.Key);
                }
            }

            SessionsData.IPAddress = "";
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }        
        [Route("forbidden")]
        public IActionResult Forbidden()
        {
            return View();
        }

        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = _configuration["Settings:Issuer"];
            validationParameters.ValidIssuer = _configuration["Settings:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Settings:Key"]));

            ClaimsPrincipal principal =
                new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return principal;
        }
        private string GenerateAuthId()
        {
            using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
            {
                byte[] tokenData = new byte[32];
                rng.GetBytes(tokenData);
                return Convert.ToBase64String(tokenData);
            }
        }
    }
}
