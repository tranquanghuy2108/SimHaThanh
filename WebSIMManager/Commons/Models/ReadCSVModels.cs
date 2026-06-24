using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Models
{
    public class ReadSimCSVModel
    {
        public string? phoneNumber { get; set; }
        public double price { get; set; }
        public double priceOfAgent { get; set; }
        public double agentSIMPrice { get; set; }
        public double collaboratorsSIMPrice { get; set; }
        public string? seria { get; set; }
        public string network { get; set; }
        public string position { get; set; }
        public string productType { get; set; }
        public string? description { get; set; }
        public string result { get; set; } = string.Empty;
    }
    public class ReadMaterialSeriaCSVModel
    {
        public int? warehouseId { get; set; }
        public string? phoneNumber { get; set; }
        public string? seria { get; set; }
        public string? position { get; set; }
        public double price { get; set; }
        public string result { get; set; } = string.Empty;
        public bool isValid { get; set; }
    }
}
