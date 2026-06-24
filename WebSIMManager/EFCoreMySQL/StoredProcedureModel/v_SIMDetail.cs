using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.StoredProcedureModel
{
    public class v_SIMDetail
    {
        public int? Id { get; set; }
        public string? Number { get; set; }
        public string? Seria { get; set; }
        public string? Network { get; set; }
        public string? ProductType { get; set; }
        public double? Price { get; set; }
        public double? SIMEmbryoFee { get; set; }
        public double? SIMServiceFee { get; set; }
        public string? Owner { get; set; }
        public string? OwnerPhoneNumber { get; set; }
        public string? Status { get; set; }
        public string? SIMImgUrl { get; set; }
        public string? Position { get; set; }
        public string? Description { get; set; }
    }
}
