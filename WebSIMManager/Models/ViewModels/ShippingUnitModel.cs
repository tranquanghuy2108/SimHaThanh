using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class ShippingUnitModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tên đơn vị vận chuyển.")]
        public string Name { get; set; }
        public string? APIUrl { get; set; }
        public string? Token { get; set; }
        public string? Description { get; set; }
    }
}
