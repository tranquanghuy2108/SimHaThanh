using Commons.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMySQL.EntityModels
{
    [Table("Receipts")]
    public class Receipt : EntityCommon
    {
        public string Code { get; set; }
        public double OldDebt { get; set; }
        public double Receivables { get; set; }
        public double Liabilities { get; set; }
        public double NewDebt { get; set; }
        public Guid AgentId { get; set; }
        public string AgentName { get; set; }
        public string AgentInfo { get; set; }
        public FormOfPayment formOfPayment { get; set; }
        public Guid? StaffId { get; set; }
        public int? BankId { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public Guid approvedBy { get; set; }
        public DateTime? approvedTime { get; set; }
        public DateTime ReceiptDate { get; set; }
    }
}
