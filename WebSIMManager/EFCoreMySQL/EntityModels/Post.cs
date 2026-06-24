using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("Posts")]
    public class Post : EntityCommon
    {
        public int ViewCount { get; set; }
        public string? Content { get; set; }
    }
}
