using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class AuctionViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int SimId { get; set; }
        public string SimNumber { get; set; }
        public string? Network { get; set; }
        public int BidderNum { get; set; }
        public double AuctionPrice { get; set; }
        public string? Note { get; set; }
        public AuctionUserBiddingModel BiddingWin { get; set; }
    }
    public class AuctionModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tên phiên đấu giá.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập thời gian bắt đấu.")]
        public DateTime StartTime { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập thời gian kết thúc.")]
        public DateTime EndTime { get; set; }
        public int SimId { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập sim đấy giá.")]
        public string SimNumber { get; set; }
        public string? Network { get; set; }
        public int BidderNum { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập giá khởi điểm.")]
        public double AuctionPrice { get; set; }
        public string? Note { get; set; }
    }
    public class AuctionUserBiddingModel
    {
        public int? Id { get; set; }
        public int AuctionId { get; set; }
        public Guid UserId { get; set; }
        public string? UserName { get; set; }
        public double Price { get; set; }
    }
}
