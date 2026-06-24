using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("Warehouse")]
    public class Warehouse: EntityCommon
    {
        public int GoodsReceivedNoteId { get; set; }
        public int GoodsDeliveryNoteId { get; set; }
        public int MaterialId { get; set; }
        public string? MaterialCode { get; set; }
        public string? MaterialName { get; set; }
        public int MaterialTypeId { get; set; }
        public string? MaterialTypeCode { get; set; }
        public string? MaterialTypeName { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double PriceAfterDiscount { get; set; }
        public string? Note { get; set; }
        public bool UsingSeria { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public DateTime ApprovedTime { get; set; }
        public Guid? ApprovedBy { get; set; }
    }
}
