using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("SIMWithOrders")]
    public class SIMWithOrder
    {
        [Key]
        [Column(Order = 1)]
        public int SimId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int OrderId { get; set; }
        public bool? UsingEsim { get; set; }

        [ForeignKey("SimId")]
        public virtual SIMDetail? sim { get; set; }

        [ForeignKey("OrderId")]
        public virtual SIMOrder? type { get; set; }
    }
}
