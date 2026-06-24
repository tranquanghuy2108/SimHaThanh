using Commons.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMySQL.EntityModels
{
    [Table("DebtBanks")]
    public class DebtBank : EntityCommon
    {
        public int? InvoiceId { get; set; }
        public string DebtCode { get; set; }
        public double Receivables { get; set; }
        public double Liabilities { get; set; }
        public double FinalDebt { get; set; }
        public int BankId { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public Guid approvedBy { get; set; }
        public DateTime approvedTime { get; set; }
        [DefaultValue(false)]
        public bool IsDebtSettlement { get; set; }
    }
}
