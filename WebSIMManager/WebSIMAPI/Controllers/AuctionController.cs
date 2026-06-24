using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Repositories.Interface;

namespace WebSIMAPI.Controllers
{
    [Route("api/auction")]
    [ApiController]
    [Authorize]
    public class AuctionController : Controller
    {
        private readonly IAuctionRepository _auctionRepository;

        public AuctionController(IAuctionRepository auctionRepository)
        {
            _auctionRepository = auctionRepository;
        }

        [HttpPost("get-current-auction")]
        public ResponseDataViewModel<AuctionViewModel> GetCurrentAuction()
        {
            return _auctionRepository.GetCurentAuction();
        }

        [HttpPost("get-my-auction")]
        public ResponseDataViewModel<AuctionViewModel> GetMyAuction([FromBody] Guid userId)
        {
            return _auctionRepository.GetMyAuction(userId);
        }

        [HttpPost("get-all-auction")]
        public ResponseDataViewModel<AuctionViewModel> GetAuction(
            [FromBody] GetPagingRequest request
        )
        {
            return _auctionRepository.GetAuction(request);
        }

        [HttpPost("bidding-auction")]
        public ResponseDataModel<string> BiddingAuction([FromBody] AuctionUserBiddingModel request)
        {
            return _auctionRepository.CreateBiddingAuction(request);
        }
    }
}
