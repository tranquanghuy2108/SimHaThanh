using Models.Requests;

namespace Models.ViewModels
{
    public class LogSYSViewModel
    {
        public string? ipAddressUser { get; set; }
        public string? controllerName { get; set; }
        public string? actionName { get; set; }
        public string? oldData { get; set; }
        public string? newData { get; set; }
        public string? createBy { get; set; }
        public DateTime createTime { get; set;}
        public int TotalCount { get; set; }
    }
    public class LogSYSRequestModel : PagingRequestBase
    {
        //public List<string>? createBy { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }
}
