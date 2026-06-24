using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("CollaboratorsGroups")]
    public class CollaboratorsGroup : EntityCommon
    {
        [StringLength(10)]
        public string? Code { get; set; }
        [StringLength(30)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [DefaultValue(false)]
        public bool IsApp { get; set; }
        [DefaultValue(false)]
        public bool IsForAgent { get; set; }
        public Guid OwnerId { get; set; }
    }
}
