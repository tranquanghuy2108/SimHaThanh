using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class SPContactViewModel
    {
        public int stt { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Account { get; set; }
        public string? Description { get; set; }
    }
    public class SPContactCreateModel
    {
        [Required(ErrorMessage = "Bạn chưa nhập tên kênh bán.")]
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Account { get; set; }
        public string? Description { get; set; }
    }
    public class SPContactEditModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tên kênh bán.")]
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Account { get; set; }
        public string? Description { get; set; }
    }
}
