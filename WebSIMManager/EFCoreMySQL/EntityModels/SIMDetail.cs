using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("SIMDetails")]
    public class SIMDetail : EntityCommon
    {
        [StringLength(20)]
        public string? SIMNumber { get; set; }
        public string? SIMSeriaNumber { get; set; }
        public double SIMPrice { get; set; }
        public double SIMPriceOfAgent { get; set; }
        public double AgentSIMPrice { get; set; }
        public double CollaboratorsSIMPrice { get; set; }
        public double SIMEmbryoFee { get; set; }
        public double SIMServiceFee { get; set; }
        public int SIMNetworkId { get; set; }
        public int ProductTypeId { get; set; }
        public string? SIMImgUrl { get; set; }
        public Guid? Owner { get; set; }
        public string? Description { get; set; }
        public string nguHanhSim { get; set; }
        public string nguHanhTuongSinh { get; set; }
        public string amDuongTuongSinh { get; set; }
        public float point { get; set; }
        public ApprovedStatus status { get; set; }
        public bool IsMySim { get; set; }
        public bool IsVerify { get; set; }
        public string? Position { get; set; }
    }
}
