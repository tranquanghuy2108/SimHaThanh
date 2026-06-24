using Commons.Enums;
using Commons.Models;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IDebtRepository
    {
        ResponseDataViewModel<DebtViewModels> GetDebt(DebtFilterModel request);
        ResponseDataModel<string> Create(DebtModels request, string userId);
        ResponseDataModel<string> Update(DebtModels request, string userId);
        DebtModels Detail(int Id);
        ResponseDataModel<string> Delete(int Id, Guid userId);
        ResponseDataModel<string> ApprovedDebt(string debtIds, ApprovedStatus status, string userId);
        ResponseDataViewModel<DebtViewModels> GetDebtForFilter(DebtFilterRequest request);
        ResponseDataViewModel<AgencyGroupReportModel> GetAgencyGroupReport(AgencyGroupReportRequest request);
        double GetOldDebt(string userId);
        ResponseDataViewModel<DebtStaffReportModel> GetDebtDetail(DebtDetailFilterModel request);
        public ResponseDataViewModel<DebtStaffReportModel> GetDebtBankDetail(DebtDetailFilterModel request);
        public ResponseDataViewModel<DebtStaffReportModel> GetDebtShippingDetail(DebtDetailFilterModel request);
        ResponseDataModel<string> ConfirmDebtSettlementOfStaff(string debtIds, bool isDebtSettlement, string userId);
        ResponseDataModel<string> ConfirmDebtSettlementOfBank(string debtIds, bool isDebtSettlement, string userId);
        ResponseDataModel<string> ConfirmDebtSettlementOfShipping(string debtIds, bool isDebtSettlement, string userId);
        public ResponseDataViewModel<CashFundBalanceReportModel> GetCashFundBalance(CashFundBalanceReportRequest request);
        public ResponseDataViewModel<BankFundBalanceReportModel> GetBankFundBalance(CashFundBalanceReportRequest request);
        public ResponseDataViewModel<ShippingFundBalanceReportModel> GetShippingFundBalance(CashFundBalanceReportRequest request);
        ResponseDataModel<string> Approved(string debtIds, ApprovedStatus status, string userId);
        #region Loại công nợ phát sinh
        public ResponseDataViewModel<DebtTypeViewModel> GetDebtType(GetPagingRequest request);
        public ResponseDataModel<int> CreateDebtType(DebtTypeModel request, string userId);
        public DebtTypeModel DetailDebtType(int Id);
        public ResponseDataModel<string> UpdateDebtType(DebtTypeModel request, string userId);
        public ResponseDataModel<string> DeleteDebtType(int Id, Guid userId);
        public List<SelectListItem> GetDebtTypeForCombo();
        #endregion

        #region Lệnh chuyển tiền

        public ResponseDataViewModel<TransferMoneyViewModel> GetTransferMoney(TransferMoneyFilterModel request);

        public ResponseDataModel<int> CreateTransferMoney(TransferMoneyModel request, string userId);

        public TransferMoneyModel DetailTransferMoney(int Id);

        public ResponseDataModel<string> UpdateTransferMoney(TransferMoneyModel request, string userId);

        public ResponseDataModel<string> DeleteTransferMoney(int Id, Guid userId);

        public ResponseDataModel<CheckTransferMoneyResponseModel> CheckTransferMoneyLst(List<int> deffStaffIds);

        public ResponseDataModel<string> ApprovedTransferMoney(TransferMoneApprovedModel request, string userId);

        #endregion

        #region Phiếu thu
        public ResponseDataViewModel<ReceiptViewModel> GetReceipt(ReceiptFilterModel request);
        public ResponseDataModel<int> CreateReceipt(ReceiptModel request, string userId);
        public ReceiptModel DetailReceipt(int Id);
        public ResponseDataModel<string> UpdateReceipt(ReceiptModel request, string userId);
        public ResponseDataModel<string> DeleteReceipt(int Id, Guid userId);
        public ResponseDataModel<string> ApprovedReceipt(ReceiptApprovedModel request, string userId);
        double CheckOldDebtOfAgent(DebtOfAgentRequest request);
		#endregion
	}
}
