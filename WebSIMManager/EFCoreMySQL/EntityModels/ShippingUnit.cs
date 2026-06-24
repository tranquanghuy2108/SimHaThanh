using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("ShippingUnits")]
    public class ShippingUnit : EntityCommon
    {
        public string Name { get; set; }
        public string? APIUrl { get; set; }
        public string? Token { get; set; }
        public string? Description { get; set; }
    }
}
