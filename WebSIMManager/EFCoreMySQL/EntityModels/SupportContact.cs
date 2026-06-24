using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("SupportContacts")]
    public class SupportContact : EntityCommon
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Account { get; set; }
        public string? Description { get; set; }
    }
}
