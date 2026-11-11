using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commons.Enums;

namespace EFCoreMySQL.EntityModels
{
    [Table("UserBlocks")]
    public class UserBlock : EntityCommon
    {
        public Guid BlockerUserId { get; set; }
        public Guid BlockedUserId { get; set; }
    }
}
