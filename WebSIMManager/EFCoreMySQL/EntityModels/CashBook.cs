using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("CashBooks")]
    public class CashBook : EntityCommon
    {
        public Guid UserId { get; set; }
        public CashActionType cashActionType { get; set; }
        public bool OnApp { get; set; }
        public double Receivables { get; set; }
        public double Liabilities { get; set; }
        public double FinalDebt { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public Guid? approvedBy { get; set; }
        public DateTime? approvedTime { get; set; }
    }
}
