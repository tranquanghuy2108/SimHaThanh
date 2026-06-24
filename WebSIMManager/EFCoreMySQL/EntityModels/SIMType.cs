using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("SIMTypes")]
    public class SIMType
    {
        [Key]
        [Column(Order = 1)]
        public int SimId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int TypeId { get; set; }

        [ForeignKey("SimId")]
        public virtual SIMDetail? sim { get; set; }
        [ForeignKey("TypeId")]
        public virtual TypeOfSIM? type { get; set; }
    }
}
