using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("TypesOfSIM")]
    public class TypeOfSIM : EntityCommon
    {
        [StringLength(50)]
        public string? Name { get; set; }
        public string? Format { get; set; }
        public double EstimatedPrice { get; set; }
        [StringLength(250)]
        public string? Description { get; set; }
    }
}
