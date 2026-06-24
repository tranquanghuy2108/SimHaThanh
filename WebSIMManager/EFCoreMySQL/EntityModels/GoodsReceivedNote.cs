using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("GoodsReceivedNotes")]
    public class GoodsReceivedNote: EntityCommon
    {
        public string Code { get; set; }
        public Guid? SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierPhone { get; set; }
        public string? SupplierAddress { get; set; }
        public Guid? StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? StaffPhone { get; set; }
        public string? StaffAddress { get; set; }
        public double TotalPrice { get; set; }
        public double OtherFee { get; set; }
        public double TienPhaiTra { get; set; }
        public double TienDaTra { get; set; }
        public double OldDebt { get; set; }
        public double NewDebt { get; set; }
        public string? Note { get; set; }
        public PaymentType PayOrderType { get; set; }
        public int? BankId { get; set; }
        public double CongNoPhatSinh { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public DateTime? ApprovedTime { get; set; }
        public Guid? ApprovedBy { get; set; }
        public DateTime? ReceivedDate { get; set; }
    }
}
