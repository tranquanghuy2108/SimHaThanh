using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("SIMOrders")]
    public class SIMOrder : EntityCommon
    {
        public double PriceOrder { get; set; }
        public double PriceOfSim { get; set; }
        public TypePriceSimOrder TypePriceSimOrder { get; set; }
        public int? Discount { get; set; }
        public double SIMEmbryoFee { get; set; }
        public double SIMServiceFee { get; set; }
        public Guid UserBuyId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNum { get; set; }
        public string? Address { get; set; }
        public string? Note { get; set; }
        public int FormOfDeliveryId { get; set; }
        public int? debtId { get; set; }
        public int? BankId { get; set; }
        public int? ContactId { get; set; }
        public StatusOrder Status { get; set; }
        public Guid PIC { get; set; }
        public DateTime TimeUnlock { get; set; }
        public PaymentType PayOrderType { get; set; }
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
    }
}
