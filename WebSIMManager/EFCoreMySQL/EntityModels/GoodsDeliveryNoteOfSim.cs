using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("GoodsDeliveryNoteOfSims")]
    public class GoodsDeliveryNoteOfSim : EntityCommon
    {
        public string Code { get; set; }
        public Guid? AgentId { get; set; }
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
        public double OldDebt { get; set; }
        public double NewDebt { get; set; }
        public string Note { get; set; }
        public double PhoneCard { get; set; }
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
        public ApprovedStatus approvedStatus { get; set; }
        public DateTime ApprovedTime { get; set; }
        public Guid? ApprovedBy { get; set; }        
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
        public DateTime? DeliveryDate { get; set; }
    }
}
