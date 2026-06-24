using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("PostImageLikes")]
    public class PostImageLike : EntityCommon
    {
        public int PostImgID { get; set; }

        [ForeignKey("PostImgID")]
        public virtual PostImage? PostImage { get; set; }
    }
}
