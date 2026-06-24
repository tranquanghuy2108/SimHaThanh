using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMySQL.EntityModels
{
    [Table("AuctionUserBidding")]
    public class AuctionUserBidding : EntityCommon
    {
        public int AuctionId { get; set; }
        public Guid UserId { get; set; }
        public string? UserName { get; set; }
        public double Price { get; set; }
    }
}
