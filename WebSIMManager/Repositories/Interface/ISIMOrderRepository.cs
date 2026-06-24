using Commons.Enums;
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
    public interface ISIMOrderRepository
    {
        ResponseDataViewModel<SIMOrderViewModel> GetSIMOrderPaging(GetPagingRequest request);
        ResponseDataViewModel<SIMOrderViewAPIModel> GetSIMOrderApp(Guid userId);
        ResponseDataViewModel<SIMOrderViewModel> GetSIMOrderOnHomePaging(GetPagingRequest request);
        ResponseDataModel<int> CreateSIMOrder(SIMOrderModel request);
        ResponseDataModel<string> UpdateSIMOrder(SIMOrderModel request);
        ResponseDataModel<string> UpdateStatusOrder(StatusOrder status, string orderIds, string userId);
        SIMOrderModel GetSIMOrder(int Id);
        ResponseDataModel<string> DeleteSIMOrder(int Id, string userId);
        ResponseDataViewModel<SIMOrderViewModel> SearcSIMOrderPaging(OrderFilterRequest request);
        AgentChangeResModel GetDiscountOfUser(string userId, int price);
        ResponseDataModel<bool> CheckListOrderIsOneAgent(List<int> orderIds);
        ResponseDataModel<string> CheckListOrderIsAvalible(List<int> orderIds);
        DataDiscountOfDebt GetOrderInfoInDebt(string orderIds);
        List<SelectListItem> GetFormOfDeliveryForComb(); 
        List<InstallmentSimViewModel> GetInstallmentOrder(Guid userId);
        ResponseDataViewModel<SIMOrderViewModel> GetOrderForAskSim(GetPagingRequest request);
        List<ProductTypeOfSimData> GetListSimData();
        List<ProductTypeOfSimData> GetListTouristSim();
    }
}
