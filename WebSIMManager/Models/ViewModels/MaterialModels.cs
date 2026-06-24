using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class MaterialViewModel
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Network { get; set; }
        public string? MaterialType { get; set; }
        public string? MaterialGroup { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public bool UsingSeria { get; set; }
        public bool ExportSeria { get; set; }
        public bool IsActive { get; set; }
        public bool IsSimEmbryo { get; set; }
    }    
    public class MaterialModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập mã mặt hàng.")]
        public string? Code { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tên mặt hàng.")]
        public string? Name { get; set; }
        public int NetworkId { get; set; }
        public int MaterialTypeId { get; set; }
        public int MaterialGroupId { get; set; }
        [Display(Name = "Giá")]
        [Required(ErrorMessage = "Bạn chưa nhập giá mặt hàng.")]
        public double? Price { get; set; }
        public double? InventoryQuantity { get; set; }
        public string? Description { get; set; }
        public bool UsingSeria { get; set; }
        public bool IsActive { get; set; }
        public bool IsSimEmbryo { get; set; }
    }
    public class MaterialGroupModel
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
    }
    public class MaterialTypeModel
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
    }
    public class MaterialSeriaViewModel
    {
        public int Id { get; set; }
        public int? gdnId { get; set; }
        public string? gdnCode { get; set; }
        public int? grnId { get; set; }
        public string? grnCode { get; set; }
        public int WarehouseId { get; set; }
        public int MaterialId { get; set; }
        public string? MaterialCode { get; set; }
        public string? MaterialName { get; set; }
        public string? Number { get; set; }
        public string? Seria { get; set; }
        public string? Position { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        [DefaultValue(false)]
        public bool HadSelled { get; set; }
    }
}
