using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    //Bảng nguyên vật liệu hàng nhập kho
    [Table("Materials")]
    public class Material : EntityCommon
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int NetworkId { get; set; }
        public int MaterialTypeId { get; set; }
        public int MaterialGroupId { get; set; }
        public double Price { get; set; }
        [DefaultValue(false)]
        public bool UsingSeria { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
        [DefaultValue(false)]
        public bool IsSimEmbryo { get; set; }
        public string? Description { get; set; }
    }
}
