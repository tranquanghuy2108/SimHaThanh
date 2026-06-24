using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class AppSysConfigModel
    {
        public int? Id { get; set; }
        public double Installment_DailyInterestRate { get; set; }
        public int Installment_MinimumPaymentRate { get; set; }
        public int Auction_WaitingTime { get; set; }
        public double Auction_Deposit { get; set; }
        public int AskSim_AskingTime { get; set; }
        public int AskSim_SimNumber { get; set; }
    }
}
