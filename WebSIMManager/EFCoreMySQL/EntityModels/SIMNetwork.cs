using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("SIMNetworks")]
    public class SIMNetwork : EntityCommon
    {
        [StringLength(50)]
        public string? NetworkName { get; set; }
        public string? NetworkImgUrl { get; set; }
        [StringLength(20)]
        public string? HtmlId { get; set; }
        public string? PrefixNumber { get; set; }
        [StringLength(250)]
        public string? Description { get; set; }
    }
}
