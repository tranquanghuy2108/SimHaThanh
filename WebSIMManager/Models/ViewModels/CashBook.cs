using Commons.Enums;
using Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class CashBookModel
    {
        public int? Id { get; set; }
        public Guid UserId { get; set; }
        public CashActionType cashActionType { get; set; }
        public bool OnApp { get; set; }
        public double Receivables { get; set; }
        public double Liabilities { get; set; }
        //public double FinalDebt { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public ApprovedStatus approvedStatus { get; set; }
        public Guid? approvedBy { get; set; }
        public DateTime? approvedTime { get; set; }
        public Guid? CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
    }
    public class CashBookViewModel
    {
        public int? Id { get; set; }
        public string user { get; set; }
        public string cashActionType { get; set; }
        public bool OnApp { get; set; }
        public double Receivables { get; set; }
        public double Liabilities { get; set; }
        //public double FinalDebt { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public string? approvedStatus { get; set; }
        public string? approvedBy { get; set; }
        public string? approvedTime { get; set; }
        public string? CreateBy { get; set; }
        public string? CreateTime { get; set; }
    }
    public class GetCashBookOnApp
    {
        public CashActionType? cashActionType { get; set; }
        public Guid UserId { get; set; }
    }
    public class GetCashBookPagingRequest : PagingRequestBase
    {
        public List<string>? userIds { get; set; }
    }
}
