using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("Shippings")]
    public class Shipping : EntityCommon
    {
        public int GDNId { get; set; }
        public string ShippingCode { get; set; }
        public Guid? Agent { get; set; }
        public Guid? Customer { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public int GoodsDeliveryNoteOfSimId { get; set; }
        public double SoTienThuHo { get; set; }
        public double ChiPhiThuHo { get; set; }
        public double SoTienConLai { get; set; }
        public double Note { get; set; }
        [DefaultValue(false)]
        public bool IsDelivered { get; set; }
    }
}
