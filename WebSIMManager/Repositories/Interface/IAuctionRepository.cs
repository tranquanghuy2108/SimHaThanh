using Models.Requests;
using Models.Responses;
using Models.ViewModels;

namespace Repositories.Interface
{
    public interface IAuctionRepository
    {
        ResponseDataViewModel<AuctionViewModel> GetCurentAuction();
        ResponseDataViewModel<AuctionViewModel> GetAuction(GetPagingRequest request);
        ResponseDataViewModel<AuctionViewModel> GetMyAuction(Guid userId);
        ResponseDataModel<string> CreateAuction(AuctionModel request, Guid userId);
        ResponseDataModel<string> UpdateAuction(AuctionModel request, Guid userId);
        AuctionModel DetailAuction(int Id);
        ResponseDataModel<string> DeleteAuction(int Id, Guid userId);
        ResponseDataModel<string> CreateBiddingAuction(AuctionUserBiddingModel request);
    }
}
