using Commons.Enums;
using Models.Responses;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IGoodsDeliveryNoteOfSimRepository
    {
        ResponseDataViewModel<GoodsDeliveryNoteOfSimViewModel> GetGoodsDeliveryNoteOfSim(GoodsDeliveryNoteOfSimFilterRequest request);
        ResponseDataModel<string> Create(GoodsDeliveryNoteOfSimModel request, string userId);
        ResponseDataModel<string> Update(GoodsDeliveryNoteOfSimModel request, string userId);
        GoodsDeliveryNoteOfSimModel Detail(int Id);
        ResponseDataModel<string> Delete(int Id, Guid userId);
        ResponseDataModel<string> Approved(string goodsDeliveryNoteOfSimIds, ApprovedStatus status, string userId);
        ResponseDataViewModel<GoodsDeliveryNoteOfSimViewModel> GetGoodsDeliveryNoteOfSimForFilter(GoodsDeliveryNoteOfSimFilterRequest request);
    }
}
