using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMySQL.EntityModels
{
    [Table("Auctions")]
    public class Auction : EntityCommon
    {
        public string? Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int SimId { get; set; }
        public string SimNumber { get; set; }
        public double AuctionPrice { get; set; }
        public string? Note { get; set; }
    }
}
