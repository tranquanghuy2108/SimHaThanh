using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("AppUserGroups")]
    public class AppUserGroup
    {
        [StringLength(128)]
        [Key]
        [Column(Order = 1)]
        public Guid UserId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int GroupId { get; set; }

        [ForeignKey("UserId")]
        public virtual AppUser? User { get; set; }
        [ForeignKey("GroupId")]
        public virtual AppGroup? Group { get; set;}
    }
}
