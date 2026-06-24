using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("PostLikes")]
    public class PostLikes : EntityCommon
    {
            public int PostId { get; set; }

            [ForeignKey("PostId")]
            public virtual Post? Post { get; set; }
    }
}
