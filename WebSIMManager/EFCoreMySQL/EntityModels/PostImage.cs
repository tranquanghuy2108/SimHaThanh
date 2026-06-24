using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("PostImages")]
    public class PostImage : EntityCommon
    {
        public int PostID { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }

        [ForeignKey("PostID")]
        public virtual Post? Post { get; set; }
    }
}
