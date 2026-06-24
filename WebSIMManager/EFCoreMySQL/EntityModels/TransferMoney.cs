using Commons.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMySQL.EntityModels
{
    [Table("TransferMoneys")]
    public class TransferMoney : EntityCommon
    {
        public string Code { get; set; }
        public double Amount { get; set; }
        public Guid ReceiverId { get; set; }
        public Guid RemittersId { get; set; }
        public int? GRNId { get; set; }
        public int? GDNId { get; set; }
        public int? GDNSId { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public Guid approvedBy { get; set; }
        public DateTime approvedTime { get; set; }
        public int? TransferMoneyId { get; set; }
    }
}
