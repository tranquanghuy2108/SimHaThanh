using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMySQL.EntityModels
{
    [Table("SystemConfigs")]
    public class SystemConfig : EntityCommon
    {
        public double Installment_DailyInterestRate { get; set; }
        public int Installment_MinimumPaymentRate { get; set; }
        public int Auction_WaitingTime { get; set; }
        public double Auction_Deposit { get; set; }
        public int AskSim_AskingTime { get; set; }
        public int AskSim_SimNumber { get; set; }
    }
}
