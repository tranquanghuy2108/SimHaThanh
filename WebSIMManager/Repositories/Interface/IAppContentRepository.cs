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
    public interface IAppContentRepository
    {
        #region FlashSale
        ResponseDataViewModel<FlashSaleModel> GetFlashSalePaging(GetPagingRequest request);
        ResponseDataModel<string> CreateFlashSale(FlashSaleModel request, string userId);
        ResponseDataModel<string> UpdateFlashSale(FlashSaleModel request, string userId);
        FlashSaleModel GetFlashSaleDetail(int Id);
        ResponseDataModel<string> DeleteFlashSale(int Id, string userId);
        List<SIMOnFlashSaleModel> GetSimForFlashSale();
        FlashSaleModel GetCurentFlashSale();
        #endregion
    }
}
