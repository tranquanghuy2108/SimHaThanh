using Commons.CallAPIs;
using Commons.Models;
using Microsoft.AspNetCore.Mvc;
using Models.Responses;
using Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSIMAPI.Controllers
{
    [Route("api/vnpt")]
    [ApiController]
    public class VNPTPackageController : ControllerBase
    {
        [HttpPost("cac-goi-cho-thue-bao-vnpt")]
        public async Task<
            List<GetAvailablePersonalizedPackages_DATA_ITEM>
        > GetAvailablePersonalizedPackages([FromBody] string simNumber)
        {
            return await VNPTCallAPI.GetAvailablePersonalizedPackages(simNumber);
        }
    }
}
