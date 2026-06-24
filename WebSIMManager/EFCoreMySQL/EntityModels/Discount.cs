using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("Discounts")]
    public class Discount : EntityCommon
    {
        public int CollaboratorsGroupId { get; set; }
        public double PriceFrom { get; set; }
        public double PriceTo { get; set; }
        public int DiscountPer { get; set; }
        public string? Description { get; set; }
    }
}
