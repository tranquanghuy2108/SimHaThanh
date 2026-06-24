using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("ProductTypes")]
    public class ProductType : EntityCommon
    {
        [StringLength(50)]
        public string? Name { get; set; }
        public double DefaulPrice { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
        public bool IsSimData { get; set; }
        public bool IsTouristSim { get; set; }
        public int? CountryId {  get; set; }
    }
}
