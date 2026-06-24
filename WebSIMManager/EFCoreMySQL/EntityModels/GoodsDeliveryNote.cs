using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("GoodsDeliveryNotes")]
    public class GoodsDeliveryNote : EntityCommon
    {
        public string Code { get; set; }
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
        public DateTime? DeliveryDate { get; set; }
    }
}
