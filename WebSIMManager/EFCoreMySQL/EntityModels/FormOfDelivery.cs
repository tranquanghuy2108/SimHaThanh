using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("FormOfDeliveries")]
    public class FormOfDelivery : EntityCommon
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
