using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMySQL.EntityModels
{
    [Table("SIMOnFlashSales")]
    public class SIMOnFlashSale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FlashSaleId { get; set; }
        public int SimId { get; set; }
        public int NetworkId { get; set; }
        public string SimNumber { get; set; }
        public double SimPrice { get; set; }
        public double Discount { get; set; }
        public double SalePrice { get; set; }
    }
}
