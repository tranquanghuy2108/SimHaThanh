using Commons.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;

namespace Repositories.Interface
{
    public interface ISIMRepository
    {
        List<SimOnAppModel> GetSIMAPI(SearchSIMRequest request);
        ResponseDataViewModel<SimOnAppModel> GetSIMDataOnAppAPI(SearchSIMDataOnAppRequest request);
        List<SimOnAppModel> GetSIMOfAgentOnAppAPI(SearchSIMOfAgentOnAppRequest request);
        ResponseDataViewModel<SimOfAgentOnCMSModel> GetSIMOfAgentOnCMS(
            SearchSIMOfAgentOnAppRequest request
        );
        ResponseDataViewModel<SIMViewModel> GetSIMPaging(SIMFilterModel request);
        ResponseDataViewModel<SimOfAgentOnCMSModel> GetSIMOnHomePaging(SearchSIMRequest request);
        ResponseDataViewModel<SimOfAgentOnCMSModel> GetSIMOnHome(SearchSIMRequest request);
        Task<ResponseDataModel<List<ReadSimCSVModel>>> ImportSIM2(
            ImportSIMModel request,
            Guid userId,
            bool isAgent = false
        );
        ResponseDataModel<string> CreateSIM(SIMCreateModel request, string userId);
        ResponseDataModel<string> UpdateSIM(SIMEditModel request, string userId);
        SIMEditModel GetSIMDetail(int Id);
        SIMViewModel GetSIMInfo(int Id);
        ResponseGetSimInfoInOrderModel GetSIMInOrder(RequestGetSimInfoInOrderModel request);
        List<SimInfosInOrderModel> GetSIMInfoInOrder(RequestGetSimInfoInOrderModel request);
        ResponseDataModel<string> DeleteSIM(int Id, string userId);
        ResponseDataModel<string> DeleteAllMySIM(string userId);

        //
        List<SIMNetworkViewModel> GetSIMNetwork();
        ResponseDataViewModel<SIMNetworkViewModel> GetSIMNetworkPaging(GetPagingRequest request);
        ResponseDataModel<string> CreateSIMNetwork(SIMNetworkCreateModel request);
        ResponseDataModel<string> UpdateSIMNetwork(SIMNetworkEditModel request);
        SIMNetworkEditModel GetSIMNetwork(int Id);
        ResponseDataModel<string> DeleteSIMNetwork(int Id);
        List<SelectListItem> GetSIMNetworkListForCombo(string selectedValue = "");

        //
        List<TypeOfSIMViewModel> GetTypeOfSIM();
        ResponseDataViewModel<TypeOfSIMViewModel> GetTypeOfSIMPaging(GetPagingRequest request);
        ResponseDataModel<string> CreateTypeOfSIM(TypeOfSimCreateModel request);
        ResponseDataModel<string> UpdateTypeOfSim(TypeOfSimEditModel request);
        TypeOfSimEditModel GetTypeOfSim(int Id);
        ResponseDataModel<string> DeleteSIMType(int Id);
        List<SelectListItem> GetTypeOfSIMListForCombo(string selectedValue = "");

        //
        List<SIMViewOnApp> GetSIMFlashSale();
        List<SIMViewOnApp> GetSIMSaleOnDay();
        List<SIMViewOnApp> GetSIMLastUpdate();

        //
        ResponseDataViewModel<ProductTypeViewModel> GetProductTypePaging(GetPagingRequest request);
        ResponseDataModel<string> CreateProductType(ProductTypeModel request);
        ResponseDataModel<string> UpdateProductType(ProductTypeModel request);
        ProductTypeModel GetProductTypeById(int Id);
        ResponseDataModel<string> DeleteProductType(int Id, Guid userId);
        List<SelectListItem> GetProductTypeForCombo();
        List<SelectListItem> GetProductTypeSIMDataForCombo();

        //
        int GetNetworkIdByName(string name);
        string GetNetworkNameByPrefix(string prefix);
        int GetGetProductTypeIdByName(string name);
        string CheckSimIdIsAvaliable(List<int> simIds);
        AskSimViewModel GetSimInfoForAskSim(string simNumber);
        AskSimViewModel GetSimInfoByIds(List<int> simIds, int orerId = 0);
        List<int> GetSimIdsRandom(int simNum, int productType);
        string GetSimIdsWithDataInFile(List<ReadSimCSVModel> dataInFiles, string agentId);
        public ResponseDataModel<string> UpdateSeriaAndFeeOfSim(
            UpdateSeriaAndFeeOfSimModel request
        );
        public ResponseDataModel<string> DeleteSimOfAgent(Guid id, string userId);

        //
        public List<InventoryReportModel> GetInventoryReport(ReportFilterModels request);
        public ResponseDataViewModel<SimInventoryCompanyReportModel> GetSimInventoryCompany(
            SimInventoryCompanyReportRequest request
        );
        public ResponseDataViewModel<WarehouseOutboundReportModel> GetWarehouseOutbound(
            WarehouseOutboundReportRequest request
        );
        public ResponseDataViewModel<SoldSimReportModel> GetSoldSim(SoldSimReportRequest request);
        public ResponseDataViewModel<ProfitSituationReportModel> GetProfitSituation(
            ProfitSituationReportRequest request
        );
        public ResponseDataViewModel<CashFundBalanceReportModel> GetCashFundBalance(
            CashFundBalanceReportRequest request
        );
        public ResponseDataViewModel<BankBalanceReportModel> GetBankBalance(
            BankBalanceReportRequest request
        );
        public ResponseDataViewModel<ProfitStatementReportModel> GetProfitStatement(
            ProfitStatementReportRequest request
        );
        public ResponseDataViewModel<OrderProfitReportModel> GetOrderProfit(
            OrderProfitReportRequest request
        );
        public ResponseDataViewModel<BankTransactionReportModel> GetBankTransaction(
            BankTransactionReportRequest request
        );
        public ResponseDataViewModel<CashFundReportModel> GetCashFund(
            CashFundReportRequest request
        );
        public ResponseDataViewModel<SimInventoryReportModel> GetSimInventory(
            SimInventoryReportRequest request
        );
        public ResponseDataViewModel<OrderImportExportReportModel> GetOrderImportExport(
            OrderImportExportReportRequest request
        );
        public ResponseDataViewModel<InventoryMovementReportModel> GetInventoryMovement(
            InventoryMovementReportRequest request
        );
        public ResponseDataViewModel<CustomerDebtReportModel> GetCustomerDebt(
            CustomerDebtReportRequest request
        );
        public List<SimPhongThuyResultModel> GetSimPTOfMenhChu(
            string amDuong,
            string nguHanh,
            int pageIndex,
            int pageSize
        );
        public double GetEstimatedPrice(List<string> formatsSim);

        //
        ResponseDataModel<string> OnApprovedSimOfAgent(
            UpdateStatusSIMOfAgentRequest request,
            string userId
        );
        SimInfoOfUserModel GetSimInfoOfUser(Guid userId);
        List<ProductTypeModel> GetProductTypeOfSimData();
        List<SelectListItem> GetTouristSIMForCombo();
        List<SelectListItem> GetSIMTypeForCombo();
        List<SelectListItem> GetSIMDataNTouristForCombo();
    }
}
