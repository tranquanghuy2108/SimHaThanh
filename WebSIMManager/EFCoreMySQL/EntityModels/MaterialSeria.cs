using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commons.Enums;
using CsvHelper.Configuration.Attributes;

namespace EFCoreMySQL.EntityModels
{
    //Quản lý nguyên vật liệu có dùng seria
    [Table("MaterialSerias")]
    public class MaterialSeria : EntityCommon
    {
        public int GoodsReceivedNoteId { get; set; }
        public int GoodsDeliveryNoteId { get; set; }
        public int WarehouseId { get; set; }
        public int WarehouseDeliveryId { get; set; }
        public int MaterialId { get; set; }
        public string? MaterialCode { get; set; }
        public string? MaterialName { get; set; }
        public string? Number { get; set; }
        public string? Seria { get; set; }
        public string? Position { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }

        [DefaultValue(false)]
        public bool HadSelled { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public DateTime ApprovedTime { get; set; }
        public Guid? ApprovedBy { get; set; }
    }
}
