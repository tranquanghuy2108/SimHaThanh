using Commons.Enums;
using Models.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class GoodsDeliveryNoteOfSimViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public Guid? AgentId { get; set; }
        public string AgentName { get; set; }
        public string AgentPhone { get; set; }
        public string AgentAddress { get; set; }
        public Guid? CustomerId { get; set; }
        public string? OrderIds { get; set; }
        public string ListSimNumberInOrder { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public double Deposit { get; set; }
        public double OrderPrice { get; set; }
        public double TienDaThu { get; set; }
        public double PhaiThuConLai { get; set; }
        public double PhoneCard { get; set; }
        public double OldDebt { get; set; }
        public double NewDebt { get; set; }
        public string Note { get; set; }
        public PaymentType PayOrderType { get; set; }
        public int? BankId { get; set; }
        public double TransferAmount { get; set; }
        public string FormOfDeliveryId { get; set; }
        public string? FormOfDeliveryCode { get; set; }
        public int? ShippingUnitId { get; set; }
        public string? ShippingName { get; set; }
        public string? ShippingCode { get; set; }
        public double ShippingFee { get; set; }
        public double COD { get; set; }
        public bool FlagCOD { get; set; }
        public double OtherFee { get; set; }
        public Guid? DeliveryAgent { get; set; }
        public bool FlagThuHo { get; set; }
        public string CreateTime { get; set; }
        public string CreateBy { get; set; }
        public string approvedStatusStr { get; set; }
        public string ApprovedTime { get; set; }
        public string ApprovedBy { get; set; }
        public string DeliveryDate { get; set; }
    }
    public class GoodsDeliveryNoteOfSimModel
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public Guid? AgentId { get; set; }
        public Guid? CustomerId { get; set; }
        public string? OrderIds { get; set; }
        public string? ListSimNumberInOrder { get; set; }
        public string? CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public double Deposit { get; set; }
        public double OrderPrice { get; set; }
        public double TienDaThu { get; set; }
        public double PhaiThuConLai { get; set; }
        public double PhoneCard { get; set; }
        public double OldDebt { get; set; }
        public double NewDebt { get; set; }
        public string? Note { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public PaymentType PayOrderType { get; set; }
        public int? BankId { get; set; }
        public double TransferAmount { get; set; }
        public int? FormOfDeliveryId { get; set; }
        public string? FormOfDeliveryCode { get; set; }
        public int? ShippingUnitId { get; set; }
        public string? ShippingCode { get; set; }
        public double ShippingFee { get; set; }
        public double COD { get; set; }
        public bool FlagCOD { get; set; }
        public double OtherFee { get; set; }
        public Guid? DeliveryAgent { get; set; }
        public bool FlagThuHo { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid? CreateBy { get; set; }
        public DateTime AprovedTime { get; set; }
        public Guid? ApprovedBy { get; set; }
        public List<SimInfosInOrderModel> SimInfosInOrders { get; set; }

        //Handle sim trả góp
        //Thời hạn thanh toán
        public int InstallmentPeriod { get; set; }
        //NGày thanh toán hàng tháng
        public int DateOfPayment { get; set; }
        //Ngày hoàn thành thanh toán
        public DateTime InstallmentEndDate { get; set; }
        //Số tiền thanh toán ban đầu
        public double DownPayment { get; set; }
        //Số tiền sẽ trả góp
        public double InstallmentPayment { get; set; }
        //Tiền góp hàng tháng
        public double MonthlyInstallmentPayment { get; set; }
        //Lãi theo ngày
        public double InterestRate { get; set; }
        [Required(ErrorMessage ="Bạn chưa nhập ngày lập phiếu")]
        public DateTime? DeliveryDate { get; set; }
    }
    public class SimInfosInOrderModel
    {
        public int Id { get; set; }
        public int GDNId { get; set; }
        public int OrderId { get; set; }
        public int SimId { get; set; }
        public string SimNumber { get; set; }
        public double PriceOfSim { get; set; }
        public double DiscountOfSim { get; set; }
        public double PriceOfDiscount { get; set; }
        public double PriceAfterDiscount { get; set; }
        public string? SimSeria { get; set; }
        public double SimEmbryoFee { get; set; }
        public double SimServiceFee { get; set; }
        public Guid? AgentId { get; set; }
        public string? AgentName { get; set; }
        public double PriceOfAgent { get; set; }
        public double DiscountOfAgent { get; set; }
        public double PriceOfDiscountAgent { get; set; }
        public double PriceAfterDiscountAgent { get; set; }
    }
    public class GoodsDeliveryNoteOfSimFilterRequest : PagingRequestBase
    {
        public string debtPrefix { get; set; } = "";
        public string simNumber { get; set; } = "";
        public string code { get; set; } = "";
        public string codCode { get; set; } = "";
        public ApprovedStatus? apprStatus { get; set; }
        public List<string?> agentIds { get; set; }
        public List<string?> staffIds { get; set; }
        public string? userId { get; set; }
    }
}
