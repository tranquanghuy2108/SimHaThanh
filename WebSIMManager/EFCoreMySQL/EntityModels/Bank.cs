using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("Banks")]
    public class Bank : EntityCommon
    {
        public string Name { get; set; }
        public string Branch { get; set; }
        public string AccOwner { get; set; }
        public string AccNumber { get; set; }
        public string Description { get; set; }
    }
}
