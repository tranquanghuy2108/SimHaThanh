using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreMySQL.EntityModels
{
    [Table("AppRoleGroups")]
    public class AppRoleGroup
    {
        [StringLength(128)]
        [Key]
        [Column(Order = 1)]
        public Guid RoleId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int GroupId { get; set; }

        [ForeignKey("RoleId")]
        public virtual AppRole? AppRole { get; set; }
        [ForeignKey("GroupId")]
        public virtual AppGroup? AppGroup { get; set; }
    }
}
