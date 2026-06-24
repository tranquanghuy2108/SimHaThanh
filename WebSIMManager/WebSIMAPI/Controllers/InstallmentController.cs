using Commons.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Repositories.Interface;

namespace WebSIMAPI.Controllers
{
    [Route("api/tra-gop")]
    [ApiController]
    [Authorize]
    public class InstallmentController : Controller
    {
        private readonly ISIMOrderRepository _simorderRepository;
        private readonly ISystemConfigRepository _systemConfigRepository;

        public InstallmentController(
            ISIMOrderRepository simorderRepository,
            ISystemConfigRepository systemConfigRepository
        )
        {
            _simorderRepository = simorderRepository;
            _systemConfigRepository = systemConfigRepository;
        }

        [HttpPost("get-installment-config")]
        public InstallmentSimConfigModel GetInstallmentConfig()
        {
            return _systemConfigRepository.GetInstallmentSimConfig();
        }

        [HttpPost("ds-sim-tra-gop")]
        public List<InstallmentSimViewModel> GetInstallmentSim(Guid userId)
        {
            return _simorderRepository.GetInstallmentOrder(userId);
        }
    }
}
