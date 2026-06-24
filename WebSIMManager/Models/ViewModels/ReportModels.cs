using System.ComponentModel.DataAnnotations.Schema;
using Models.Requests;

namespace Models.ViewModels
{
    public class ReportFilterModels
    {
        public bool? isPaged { get; set; }
        public int? pageIndex { get; set; }
        public int? pageSize { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public string? agentId { get; set; }
    }

    public class InventoryReportModel
    {
        public string? stt { get; set; }
        public string? productName { get; set; }
        public string? productDesc { get; set; }
        public string? inventoryAmount { get; set; }
        public string? owner { get; set; }
    }

    public class AgencyGroupReportRequest : PagingRequestBase
    {
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }

    public class AgencyGroupReportModel
    {
        [NotMapped]
        public int? Stt { get; set; }
        public Guid? AgentId { get; set; }
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public double? TotalReceivables { get; set; }
        public double? TotalLiabilities { get; set; }
        public double? TotalFinalDebt { get; set; }
        public int TotalCount { get; set; }
    }

    public class SimInventoryCompanyReportRequest : PagingRequestBase
    {
        public int ApprStatus { get; set; }
        public bool IsMySim { get; set; }
        public bool IsSimData { get; set; }
        public bool IsConsignment { get; set; }
        public List<int>? ProductTypes { get; set; }
        public List<int>? Networks { get; set; }
        public List<Guid?> Owners { get; set; }
    }

    public class SimInventoryCompanyReportModel
    {
        public int Id { get; set; }
        public bool IsBooked { get; set; }
        public string? SIMNumber { get; set; }
        public string? Network { get; set; }
        public string? SIMType { get; set; }
        public double? SIMPrice { get; set; }
        public double? AgentSIMPrice { get; set; }
        public double? CollaboratorsSIMPrice { get; set; }
        public double? SIMPriceOfAgent { get; set; }
        public string? OwnerName { get; set; }
        public string? OwnerPhoneNumber { get; set; }
        public string? SIMSeriaNumber { get; set; }
        public string? ProductType { get; set; }
        public string? Description { get; set; }
        public string? Position { get; set; }
        public string? Status { get; set; }
        public DateTime CreateTime { get; set; }
        public int TotalCount { get; set; }
    }

    public class SimOnAppModel
    {
        public int Id { get; set; }
        public string? SIMNumber { get; set; }
        public string? Network { get; set; }
        public string? ProductType { get; set; }
        public string? SIMType { get; set; }
        public double? SIMPrice { get; set; }
        public double? SIMPriceOfAgent { get; set; }
        public string? SIMSeriaNumber { get; set; }
        public string? Description { get; set; }
        public int NextID { get; set; }
        public int TotalCount { get; set; }
    }

    public class SimOfAgentOnCMSModel
    {
        public int Id { get; set; }
        public string? SIMNumber { get; set; }
        public string? Network { get; set; }
        public string? ProductType { get; set; }
        public string? SIMType { get; set; }
        public double? SIMPrice { get; set; }
        public double? SIMPriceOfAgent { get; set; }
        public string? SIMSeriaNumber { get; set; }
        public string? OwnerName { get; set; }
        public string? OwnerPhoneNumber { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public int TotalCount { get; set; }
    }

    public class SimForCheckSimVNPYModel
    {
        public int Id { get; set; }
        public string? SIMNumber { get; set; }
        public int ProductTypeId { get; set; }
    }

    public class WarehouseOutboundReportRequest : PagingRequestBase
    {
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public List<int>? materialIds { get; set; }
    }

    public class WarehouseOutboundReportModel
    {
        public int ProductTypeId { get; set; }
        public string? ProductType { get; set; }
        public int? InvoiceId { get; set; }
        public string? InvoiceCode { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int? Quantity { get; set; }
        public double? OriginalPrice { get; set; }
        public double? SellingPrice { get; set; }
        public double? TotalSellingAmount { get; set; }
        public DateTime? ExportDate { get; set; }
        public string? Customer { get; set; }
        public string? Warehouse { get; set; }
        public string? Note { get; set; }
        public int TotalCount { get; set; }
    }

    public class SoldSimReportRequest : PagingRequestBase
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }

    public class SoldSimReportModel
    {
        public DateTime CreateTime { get; set; }
        public string? Code { get; set; }
        public string? SimNumbers { get; set; }
        public double TotalOrders { get; set; }
        public double TotalPaid { get; set; }
        public double RemainingUnpaid { get; set; }
        public string? Note { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerAddress { get; set; }
        public double BuyerDeductionFee { get; set; }
        public string? ShippingName { get; set; }
        public double COD { get; set; }
        public double ShippingFee { get; set; }
        public string? FormOfDelivery { get; set; }
        public string? Seller { get; set; }
        public string? Creator { get; set; }
        public bool FlagCOD { get; set; }
        public bool FlagThuHo { get; set; }
        public int TotalCount { get; set; }
    }

    public class ProfitSituationReportRequest : PagingRequestBase
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }

    public class ProfitSituationReportModel
    {
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public string? Unit { get; set; }
        public string? ProductGroup { get; set; }
        public double Quantity { get; set; }
        public double UnitPriceOnPurchase { get; set; }
        public double TotalPurchaseAmount { get; set; }
        public double UnitPriceOnSale { get; set; }
        public double TotalSalesAmount { get; set; }
        public double Profit { get; set; }
        public int TotalCount { get; set; }
    }

    public class CashFundBalanceReportRequest : PagingRequestBase
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }

    public class CashFundBalanceReportModel
    {
        public Guid? StaffId { get; set; }
        public string? StaffName { get; set; }
        public double CurrentBalance { get; set; }
        public double TotalBalance { get; set; }
        public int TotalCount { get; set; }
    }

    public class BankFundBalanceReportModel
    {
        public int? Id { get; set; }
        public string? BankInfo { get; set; }
        public double CurrentBalance { get; set; }
        public double TotalBalance { get; set; }
        public int TotalCount { get; set; }
    }

    public class ShippingFundBalanceReportModel
    {
        public int? Id { get; set; }
        public string? ShippingInfo { get; set; }
        public double CurrentBalance { get; set; }
        public double TotalBalance { get; set; }
        public int TotalCount { get; set; }
    }

    public class BankBalanceReportRequest : PagingRequestBase
    {
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }

    public class BankBalanceReportModel
    {
        public int Id { get; set; }
        public string? BankName { get; set; }
        public string? AccountName { get; set; }
        public string? AccountNumber { get; set; }
        public double? ApprovedTotalAmount { get; set; }
        public double? WaitingApprovedTotalAmount { get; set; }
        public int TotalCount { get; set; }
    }

    public class ProfitStatementReportRequest : PagingRequestBase { }

    public class ProfitStatementReportModel
    {
        public DateTime ExportDate { get; set; }
        public string? InvoiceCode { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? SalesChannel { get; set; }
        public bool? HomeSIM { get; set; }
        public string? NumberOfSIMs { get; set; }
        public string? Location { get; set; }
        public string? Agency { get; set; }
        public double? PurchaseAmount { get; set; }
        public double? SellingAmount { get; set; }
        public double? NotDeductedFee { get; set; }
        public double? Expenses { get; set; }
        public double? DeductedFee { get; set; }
        public string? Seller { get; set; }
        public string? Creator { get; set; }
        public string? Recorder { get; set; }
        public int TotalCount { get; set; }
    }

    public class OrderProfitReportRequest : PagingRequestBase
    {
        public int? type { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }

    public class OrderProfitReportModel
    {
        public DateTime ExportDate { get; set; }
        public int? InvoiceId { get; set; }
        public string? InvoiceCode { get; set; }
        public string? CustomerName { get; set; }
        public string? SIMNumbers { get; set; }
        public double? ImportValue { get; set; }
        public double? ExportValue { get; set; }
        public double? Interest { get; set; }
        public double? Cost { get; set; }
        public double? Difference { get; set; }
        public string? Warehouse { get; set; }
        public string? Creator { get; set; }
        public int TotalCount { get; set; }
    }

    public class BankTransactionReportRequest : PagingRequestBase
    {
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }

    public class BankTransactionReportModel
    {
        public DateTime TransactionDate { get; set; }
        public string? InvoiceCode { get; set; }
        public string? CustomerName { get; set; }
        public double? Increase { get; set; }
        public double? Decrease { get; set; }
        public string? Explanation { get; set; }
        public string? Note { get; set; }
        public int TotalCount { get; set; }
    }

    public class CashFundReportRequest : PagingRequestBase { }

    public class CashFundReportModel
    {
        public DateTime DateCreated { get; set; }
        public string? InvoiceCode { get; set; }
        public string? CustomerName { get; set; }
        public double? Income { get; set; }
        public double? Expense { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public int TotalCount { get; set; }
    }

    public class SimInventoryReportRequest : PagingRequestBase
    {
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public List<int>? materialIds { get; set; }
    }

    public class SimInventoryReportModel
    {
        public string? ProductType { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public int? OpeningInventory { get; set; }
        public int? TotalPurchases { get; set; }
        public int? TotalSales { get; set; }
        public int? ClosingInventory { get; set; }
        public int? InventoryCount { get; set; }
        public int? SurplusShortage { get; set; }
        public string? Note { get; set; }
        public int TotalCount { get; set; }
    }

    public class OrderImportExportReportRequest : PagingRequestBase
    {
        public int? type { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }

    public class OrderImportExportReportModel
    {
        public int Stt { get; set; }
        public DateTime DateOfOccurrence { get; set; }
        public int? InvoiceId { get; set; }
        public string? InvoiceCode { get; set; }
        public string? Code { get; set; }
        public string? Product { get; set; }
        public int? Quantity { get; set; }
        public string? Customer { get; set; }
        public string? InvoiceType { get; set; }
        public string? Creator { get; set; }
        public DateTime DateCreated { get; set; }
        public string? Warehouse { get; set; }
        public bool Approved { get; set; }
        public int TotalCount { get; set; }
    }

    public class InventoryMovementReportRequest : PagingRequestBase
    {
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public List<int>? materialIds { get; set; }
    }

    public class InventoryMovementReportModel
    {
        public int ProductTypeId { get; set; }
        public string? ProductTypeName { get; set; }
        public int? InvoiceId { get; set; }
        public string? InvoiceCode { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int QuantityPurchased { get; set; }
        public double? UnitPrice { get; set; }
        public double? TotalAmount { get; set; }
        public int? RemainingQuantity { get; set; }
        public DateTime DateOfEntry { get; set; }
        public string? Supplier { get; set; }
        public string? Warehouse { get; set; }
        public string? Note { get; set; }
        public int TotalCount { get; set; }
    }

    public class CustomerDebtReportRequest : PagingRequestBase
    {
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public List<string>? agentId { get; set; }
    }

    public class CustomerDebtReportModel
    {
        public DateTime TransactionDate { get; set; }
        public string? AgentName { get; set; }
        public int? InvoiceId { get; set; }
        public string? InvoiceCode { get; set; }
        public string? InvoiceType { get; set; }
        public string? NumberOfSIMs { get; set; }
        public double? ListedPrice { get; set; }
        public double? ActualPriceReceived { get; set; }
        public double? CollectDelivery { get; set; }
        public double? IncidentalFee { get; set; }
        public double? IncreaseIncidents { get; set; }
        public double? DecreaseIncidents { get; set; }
        public double? IncidentalDebt { get; set; }
        public string? Note { get; set; }
        public string? TransactionMethod { get; set; }
        public double? COD { get; set; }
        public string? Creator { get; set; }
        public int TotalCount { get; set; }
        public double? BeginningBalance { get; set; }
    }
}
