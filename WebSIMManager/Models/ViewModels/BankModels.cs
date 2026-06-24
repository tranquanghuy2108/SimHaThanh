using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class BankModels
    {
        public int? Id { get; set; }
        [Required(ErrorMessage ="Bạn chưa nhập tên ngân hàng")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập chi nhánh ngân hàng")]
        public string Branch { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập chủ tài khoản")]
        public string Owner { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập Số tài khoản")]
        public string Number { get; set; }
        public string? Description { get; set; }
    }
    public class CountryModels
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string? Note { get; set; }
    }
}
