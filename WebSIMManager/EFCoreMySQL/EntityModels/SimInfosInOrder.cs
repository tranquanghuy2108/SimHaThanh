using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.EntityModels
{
    [Table("SimInfosInOrders")]
    public class SimInfosInOrder : EntityCommon
    {
        public int GDNId { get; set; }
        public int OrderId { get; set; }
        public int SimId {  get; set; }
        public string SimNumber {  get; set; }
        public double PriceOfSim { get; set; }
        public double DiscountOfSim { get; set; }
        public double PriceOfDiscount { get; set; }
        public double PriceAfterDiscount { get; set; }
        public string SimSeria { get; set; }
        public double SimEmbryoFee { get; set; }
        public double SimServiceFee { get; set; }
        public Guid? AgentId { get; set; }
        public string AgentName { get; set; }
        public double PriceOfAgent { get; set; }
        public double DiscountOfAgent { get; set; }
        public double PriceOfDiscountAgent { get; set; }
        public double PriceAfterDiscountAgent { get; set; }
    }
}
