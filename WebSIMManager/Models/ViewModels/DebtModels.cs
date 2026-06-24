using Commons.Enums;
using Models.Requests;
using System.ComponentModel.DataAnnotations;

namespace Models.ViewModels
{
    //PhieuXuatSim filter
    public class DebtDetailFilterModel : PagingRequestBase
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<string?> userIds { get; set; }
        public DebtCategory debtCategory { get; set; }
    }
    public class DebtFilterRequest : PagingRequestBase
    {
        public string debtPrefix { get; set; } = "";
        public ApprovedStatus? apprStatus { get; set; }
        public List<string?> agentIds { get; set; }
        public List<string?> staffIds { get; set; }
        public string? userId { get; set; }
    }
    public class DebtFilterModel : PagingRequestBase
    {
        public ApprovedStatus? approvedStatus { get; set; }
        public string? userId { get; set; }
        public List<string?> agents { get; set; }
        public List<string?> pics { get; set; }
    }
    public class DebtViewModels
    {
        public int id { get; set; }
        public string? debtCode { get; set; }
        public double receivables { get; set; }
        public double liabilities { get; set; }
        public double otherFeeTotal { get; set; }
        public double finalDebt { get; set; }
        public string? orderIds { get; set; }
        public string? sims { get; set; }
        public string agentId { get; set; }
        public string? description { get; set; }
        public string? formOfDeliveryId { get; set; }
        public string? formOfDeliveryCode { get; set; }
        public string? approvedStatus { get; set; }
        public string? approvedBy { get; set; }
        public string? approvedTime { get; set; }
        public string? createTime { get; set; }
        public string? createBy { get; set; }
    }
    public class DebtModels
    {
        public int? Id { get; set; }
        public int DebtTypeId { get; set; }
        public string? DebtCode { get; set; }
        public double? Receivables { get; set; }
        public double? Liabilities { get; set; }
        public int? FormOfDeliveryId { get; set; }
        public string? FormOfDeliveryCode { get; set; }
        public string? orderIds { get; set; }
        public Guid UserBuyId { get; set; }
        public Guid AgentId { get; set; }
        public string? Description { get; set; }
        public ApprovedStatus? approvedStatus { get; set; }
        public Guid? approvedBy { get; set; }
        //
        public string? approvedByStr { get; set; }
        public string? approvedTime { get; set; }
        public string? createTime { get; set; }
        public string? createBy { get; set; }
        //For order
        public PaymentType PayOrderType { get; set; }
        public int? BankId { get; set; }
        public int? ShippingUnitId { get; set; }
        public string? ShippingCode { get; set; }
        public double ShippingFee { get; set; }
        public double MoneyCollected { get; set; }
        public double OtherFee { get; set; }
        public double PhoneCard { get; set; }
        public Guid? DeliveryAgent { get; set; }
    }
    public class DataDiscountOfDebt
    {
        public Guid? agentId { get; set; }
        public string contact { get; set; }
        public double priceOrder { get; set; }
        public int discount { get; set; }
        public double priceDiscount { get; set; }
        public double priceOfSim { get; set; }
        public List<SIMOrderModel> orderInDebts { get; set; }
        public List<SIMViewModel> simInfoInDebts { get; set; }
    }
    //
    public class ApprovedDebtRequest
    {
        public string debtIds { get; set; }
        public ApprovedStatus status { get; set; }
    }
    public class XuatSimModels
    {
        //For Debt
        public int? Id { get; set; }
        public string? DebtCodePrefix { get; set; }
        public string? DebtCode { get; set; }
        public double? Receivables { get; set; }
        public double? Liabilities { get; set; }
        public int? FormOfDeliveryId { get; set; }
        public string? FormOfDeliveryCode { get; set; }
        public string? orderIds { get; set; }
        public Guid AgentId { get; set; }
        public string? Description { get; set; }
        public ApprovedStatus? approvedStatus { get; set; }
        public Guid? approvedBy { get; set; }
        //For order
        public int? BankId { get; set; }
        public int? ShippingUnitId { get; set; }
        public string? ShippingCode { get; set; }
        public double ShippingFee { get; set; }
        public double OtherFee { get; set; }
    }
    public class DebtReportModel
    {
        public int id { get; set; }
        public string DebtCode { get; set; }
        public double Receivables { get; set; }
        public double Liabilities { get; set; }
        public double FinalDebt { get; set; }
        public string? PIC { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public string? approvedStatus { get; set; }
        public string? approvedBy { get; set; }
        public DateTime? approvedTime { get; set; }
        public DateTime? createTime { get; set; }
        public string? createBy { get; set; }
        public int TotalCount { get; set; }
    }
    public class DebtStaffReportModel
    {
        public int? id { get; set; }
        public int? InvoiceId { get; set; }
        public string DebtCode { get; set; }
        public double Receivables { get; set; }
        public double Liabilities { get; set; }
        public double FinalDebt { get; set; }
        public string? PIC { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public string? approvedStatus { get; set; }
        public string? approvedBy { get; set; }
        public DateTime? approvedTime { get; set; }
        public DateTime? createTime { get; set; }
        public string? createBy { get; set; }
        public string? transferMoneyCode { get; set; }
        public bool isDebtSettlement { get; set; }
        public int TotalCount { get; set; }
    }

    #region Loại công nợ phát sinh
    public class DebtTypeViewModel
    {
        public int? Stt { get; set; }
        public int? Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DebtReceiveType { get; set; }
        public string? Description { get; set; }
    }

    public class DebtTypeModel
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DebtReceiveType DebtReceiveType { get; set; }
        public string? Description { get; set; }
    }
    #endregion

    #region Lệnh chuyển tiền
    public class TransferMoneyFilterModel : PagingRequestBase
    {
        public List<string>? RemittersIds { get; set; }
        public string ReceiverId { get; set; }
    }
    public class TransferMoneApprovedModel : PagingRequestBase
    {
        public string TransferMoneyIds { get; set; }
        public ApprovedStatus Status { get; set; }
    }
    public class CheckTransferMoneyRequestModel : PagingRequestBase
    {
        public List<int> DebtStaffIds { get; set; }
    }
    public class CheckTransferMoneyResponseModel : PagingRequestBase
    {
        public List<int> DebtStaffIds { get; set; }
        public List<string> DebtStaffCodes { get; set; }
        public double TotalAmount {  get; set; }
    }
    public class TransferMoneyViewModel
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public double Amount { get; set; }
        public string ReceiverId { get; set; }
        public string RemittersId { get; set; }
        public string DebtStaffCodes { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public string approvedStatus { get; set; }
        public string approvedBy { get; set; }
        public string approvedTime { get; set; }
    }
    public class TransferMoneyModel
    {
        public int? Id { get; set; }
        public string? Code { get; set; }
        public double Amount { get; set; }
        public Guid ReceiverId { get; set; }
        public Guid RemittersId { get; set; }
        public List<int> DebtStaffIds { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public Guid approvedBy { get; set; }
        public DateTime approvedTime { get; set; }
    }    
    public class CreateTransferMoneyModel
    {
        public int? Id { get; set; }
        public string? Code { get; set; }
        public double Amount { get; set; }
        public string ReceiverId { get; set; }
        public string RemittersId { get; set; }
        public List<int> DebtStaffIds { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
    #endregion

    #region Phiếu thu
    public class ReceiptFilterModel : PagingRequestBase
    {
        public List<string>? AgentIds { get; set; }
    }
    public class ReceiptApprovedModel : PagingRequestBase
    {
        public string ReceiptIds { get; set; }
        public ApprovedStatus Status { get; set; }
    }
    public class CheckReceiptRequestModel : PagingRequestBase
    {
        public List<int> DebtAgentIds { get; set; }
    }
    public class CheckReceiptResponseModel : PagingRequestBase
    {
        public List<int> DebtAgentIds { get; set; }
        public List<string> DebtAgentCodes { get; set; }
        public double TotalAmount { get; set; }
    }
    public class ReceiptViewModel
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public double OldDebt { get; set; }
        public double Receivables { get; set; }
        public double Liabilities { get; set; }
        public double NewDebt { get; set; }
        public Guid AgentId { get; set; }
        public string AgentName { get; set; }
        public string AgentInfo { get; set; }
        public string formOfPayment { get; set; }
        public Guid? StaffId { get; set; }
        public int? BankId { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public string approvedStatus { get; set; }
        public string approvedBy { get; set; }
        public string CreateBy { get; set; }
        public string? approvedTime { get; set; }
        public string? ReceiptDate { get; set; }
    }    
    public class ReceiptModel
    {
        public int? Id { get; set; }
        public string? Code { get; set; }
        public double OldDebt { get; set; }
        public double Receivables { get; set; }
        public double Liabilities { get; set; }
        public double NewDebt { get; set; }
        public Guid AgentId { get; set; }
        public string AgentName { get; set; }
        public string AgentInfo { get; set; }
        public FormOfPayment formOfPayment { get; set; }
        public TypeOfReceived typeOfReceived { get; set; }
        public Guid? StaffId { get; set; }
        public int? BankId { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public Guid approvedBy { get; set; }
        public DateTime? approvedTime { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập ngày lập phiếu")]
        public DateTime? ReceiptDate { get; set; }
        public Guid? CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
    }

    #endregion
}
