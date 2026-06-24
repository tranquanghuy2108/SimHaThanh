using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("LogActions")]
    public class LogAction : EntityCommon
    {
        public string? IpAddressUser { get; set; }
        public string? ControllerName { get; set; }
        public string? ActionName { get; set; }
        public string? OldData { get; set; }
        public string? NewData { get; set; }
    }
}
