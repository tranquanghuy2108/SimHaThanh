using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Responses;
using Models.ViewModels;
using Repositories.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSIMAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CashBookController : ControllerBase
    {
        private readonly ICashBookRepository _cashBookRepository;

        public CashBookController(ICashBookRepository cashBookRepository)
        {
            _cashBookRepository = cashBookRepository;
        }

        [HttpPost("get-ki-quy")]
        public List<CashBookModel> GetCashBookByType([FromBody] GetCashBookOnApp request)
        {
            return _cashBookRepository.GetCashBookByType(request);
        }

        [HttpPost("ki-quy")]
        public ResponseDataModel<string> CreateCashBook([FromBody] CashBookModel model)
        {
            return _cashBookRepository.CreateCashBook(model, model.UserId);
        }

        [HttpPost("tien-trong-quy")]
        public double GetMoneyInCash([FromBody] Guid userId)
        {
            return _cashBookRepository.GetMoneyInCash(userId);
        }
    }
}
