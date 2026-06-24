using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("PostImageComments")]
    public class PostImageComment : EntityCommon
    {
        public int PostImgID { get; set; }
        public int? ParentImgCmtID { get; set; } //~ParentImageCommentID
        public string? Content { get; set; }

        [ForeignKey("PostImgID")]
        public virtual PostImage? PostImage { get; set; }
        [ForeignKey("ParentImgCmtID")]
        public virtual PostImageComment? ParentImgCmt { get; set; }
    }
}
