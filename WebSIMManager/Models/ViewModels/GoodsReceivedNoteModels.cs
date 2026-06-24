using Commons.Enums;
using Models.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class GoodsReceivedNoteViewModel
    {
        public int? Id { get; set; }
        public string? Code { get; set; }
        public Guid? SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierPhone { get; set; }
        public string? SupplierAddress { get; set; }
        public Guid? StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? StaffPhone { get; set; }
        public string? StaffAddress { get; set; }
        public double TotalPrice { get; set; }
        public double OtherFee { get; set; }
        public double TienPhaiTra { get; set; }
        public double TienDaTra { get; set; }
        public string? Note { get; set; }
        public string? CreateBy { get; set; }
        public string? CreateTime { get; set; }
        public string? approvedStatus { get; set; }
        public string? ApprovedTime { get; set; }
        public string? ApprovedBy { get; set; }
        public string? Warehouses { get; set; }
        public string? ReceivedDate { get; set; }
    }
    public class GoodsReceivedNoteModel
    {
        public int? Id { get; set; }
        public string? Code { get; set; }
        public Guid? SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierPhone { get; set; }
        public string? SupplierAddress { get; set; }
        public Guid? StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? StaffPhone { get; set; }
        public string? StaffAddress { get; set; }
        public double TotalPrice { get; set; }
        public double OtherFee { get; set; }
        public double TienPhaiTra { get; set; }
        public double TienDaTra { get; set; }
        public double NoLai { get; set; }
        public double OldDebt { get; set; }
        public double NewDebt { get; set; }
        public string? Note { get; set; }
        public PaymentType PayOrderType { get; set; }
        public int? BankId { get; set; }
        public double CongNoPhatSinh { get; set; }
        public Guid? CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập ngày nhập kho.")]
        public DateTime? ReceivedDate { get; set; }
        public ApprovedStatus? approvedStatus { get; set; }
        public DateTime? ApprovedTime { get; set; }
        public Guid? ApprovedBy { get; set; }
        //
        [Required(ErrorMessage = "Bạn chưa nhập mặt hàng.")]
        public List<WarehouseModel> Warehouses { get; set; }
    }
    public class WarehouseModel
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public string? MaterialCode { get; set; }
        public string? MaterialName { get; set; }
        public int MaterialTypeId { get; set; }
        public string? MaterialTypeCode { get; set; }
        public string? MaterialTypeName { get; set; }
        public double InventoryQuantity { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double PriceAfterDiscount { get; set; }
        public string? Note { get; set; }
        public bool UsingSeria { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public DateTime ApprovedTime { get; set; }
        public Guid? ApprovedBy { get; set; }
        public List<MaterialSeriaModel>? materialSerias { get; set; }
    }
    public class MaterialSeriaModel
    {
        public int Id { get; set; }
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
    public class GoodsReceivedNoteFilterRequest : PagingRequestBase
    {
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }
        public ApprovedStatus? apprStatus { get; set; }
        public List<string?> SupplierIds { get; set; }
        public List<string?> staffIds { get; set; }
        public string? userId { get; set; }
    }
}
