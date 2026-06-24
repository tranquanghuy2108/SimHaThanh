using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("PostComments")]
    public class PostComment : EntityCommon
    {
        public int PostId { get; set; }
        public int? ParentCommentID { get; set; }
        public string? Content { get; set; }

        [ForeignKey("PostId")]
        public virtual Post? Posts { get; set; }
        [ForeignKey("ParentCommentID")]
        public virtual PostComment? Comments { get; set; }
    }
}
