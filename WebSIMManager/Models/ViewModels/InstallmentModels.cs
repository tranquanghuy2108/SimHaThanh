using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class InstallmentRequestModel
    {
        public double simPrice { get; set; }
        public double DownPayment { get; set; }
        public int months { get; set; }
    }
    public class InstallmentSimViewModel
    {
        public string SimNumber { get; set; }
        public int OrderId { get; set; }
        public double OrderPrice { get; set; }
        public string UserBuy { get; set; }
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
        public string? Note { get; set; }
        public string ApprovedStatus { get; set; }
    }
    public class InstallmentSimModel
    {
        public int Id { get; set; }
        public int SimId { get; set; }
        public int OrderId { get; set; }
        public int GDNOfSimId { get; set; }
        public Guid UserBuyId { get; set; }
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
        public string? Note { get; set; }
        public ApprovedStatus ApprovedStatus { get; set; }
        public Guid ApprovedBy { get; set; }
        public DateTime ApprovedTime { get; set; }
        //Check trạng thái thanh toán
        [DefaultValue(false)]
        public bool IsDebtSettlement { get; set; }
    }
    public class InstallmentSimConfigModel
    {
        public double Installment_DailyInterestRate { get; set; }
        public int Installment_MinimumPaymentRate { get; set; }
    }
}
