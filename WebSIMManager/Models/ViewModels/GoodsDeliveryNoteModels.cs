using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commons.Enums;
using Models.Requests;

namespace Models.ViewModels
{
    public class GoodsDeliveryNoteViewModel
    {
        public int? Id { get; set; }
        public string? Code { get; set; }
        public string ListMaterial { get; set; }
        public Guid? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerAddress { get; set; }
        public Guid? StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? StaffPhone { get; set; }
        public string? StaffAddress { get; set; }
        public double TotalPrice { get; set; }
        public double OtherFee { get; set; }
        public double PhaiThuConLai { get; set; }
        public double TienDaThu { get; set; }
        public string? Note { get; set; }
        public string? CreateBy { get; set; }
        public string? CreateTime { get; set; }
        public string? approvedStatus { get; set; }
        public string? ApprovedTime { get; set; }
        public string? ApprovedBy { get; set; }
        public string? Warehouses { get; set; }
        public string? DeliveryDate { get; set; }
    }

    public class GoodsDeliveryNoteModel
    {
        public int? Id { get; set; }
        public string? Code { get; set; }
        public string? ListMaterial { get; set; }
        public Guid? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerAddress { get; set; }
        public Guid? StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? StaffPhone { get; set; }
        public string? StaffAddress { get; set; }
        public double TotalPrice { get; set; }
        public double OtherFee { get; set; }
        public double TienDaThu { get; set; }
        public double PhaiThuConLai { get; set; }
        public double NoLai { get; set; }
        public double OldDebt { get; set; }
        public double NewDebt { get; set; }
        public string? Note { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public PaymentType PayOrderType { get; set; }
        public int? BankId { get; set; }
        public int? FormOfDeliveryId { get; set; }
        public string? FormOfDeliveryCode { get; set; }
        public int? ShippingUnitId { get; set; }
        public string? ShippingCode { get; set; }
        public double ShippingFee { get; set; }
        public double COD { get; set; }
        public bool FlagCOD { get; set; }
        public Guid? DeliveryAgent { get; set; }
        public double SoTienThuHo { get; set; }
        public double CongNoPhatSinhGiaoDichHo { get; set; }
        public bool FlagThuHo { get; set; }
        public DateTime ApprovedTime { get; set; }
        public Guid? ApprovedBy { get; set; }
        public DateTime CreateTime { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập ngày xuất kho.")]
        public DateTime? DeliveryDate { get; set; }
        public Guid? CreateBy { get; set; }
        public List<WarehouseModel>? Warehouses { get; set; }
    }

    public class GoodsDeliveryNoteFilterRequest : PagingRequestBase
    {
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }
        public ApprovedStatus? apprStatus { get; set; }
        public List<string?> SupplierIds { get; set; }
        public List<string?> staffIds { get; set; }
        public string? userId { get; set; }
    }
}
