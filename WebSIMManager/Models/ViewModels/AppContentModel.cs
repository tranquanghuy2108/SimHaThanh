using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class FlashSaleModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage ="Bạn chưa nhập tên phiên flashsale")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập thời gian bắt đầu phiên flashsale")]
        public DateTime StartTime { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập thời gian kết thúc phiên flashsale")]
        public DateTime EndTime { get; set; }
        public string? Description { get; set; }
        public List<SIMOnFlashSaleModel> SimFlashSaleInfos { get; set; }
    }
    public class SIMOnFlashSaleModel
    {
        public int FlashSaleId { get; set; }
        public int SimId { get; set; }
        public int NetworkId { get; set; }
        public string SimNumber { get; set; }
        public double SimPrice { get; set; }
        public double Discount { get; set; }
        public double SalePrice { get; set; }
    }
}
