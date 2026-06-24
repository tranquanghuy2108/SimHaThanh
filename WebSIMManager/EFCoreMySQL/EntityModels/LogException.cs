using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("LogExceptions")]
    public class LogException : EntityCommon
    {
        public string? ControllerName { get; set; }
        public string? ActionName { get; set; }
        public string? ExceptionName { get; set; }
    }
}
