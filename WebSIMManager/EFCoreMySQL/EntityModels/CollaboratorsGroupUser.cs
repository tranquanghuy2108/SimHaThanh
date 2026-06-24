using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("CollaboratorsGroupUser")]
    public class CollaboratorsGroupUser
    {
        public int CollaboratorsGroupId { get; set; }
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual AppUser? User { get; set; } 

        [ForeignKey("CollaboratorsGroupId")]
        public virtual CollaboratorsGroup? CollaboratorsGroup { get; set; } 
    }
}
