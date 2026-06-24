using Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Requests
{
    public class GetPagingRequest : PagingRequestBase
    {

    }
    public class GetMateriaSeriaPagingRequest : PagingRequestBase
    {
        public string MateriaSeriaIds { get; set; }
        public string HadSelled { get; set; }
    }
    public class GetCommentRequest : PagingRequestBase
    {
        public int PostID { get; set; }
    }
    public class GetLikeRequest : PagingRequestBase
    {
        public int PostID { get; set; }
    }
    public class GetImageRequest : PagingRequestBase
    {
         public int PostID { get; set; }
    }
    public class GetSIMRequest : PagingRequestBase
    {

    }
    public class SearchSIMRequest : PagingRequestBase
    {
        public List<int>? networkIds { get; set; } = new List<int>();
        public List<int>? simTypeIds { get; set; } = new List<int>();
        public List<int>? productTypeIds { get; set; } = new List<int>();
        public List<string>? prefixs { get; set; } = new List<string>();
        public List<string>? avoidNums { get; set; } = new List<string>();
        public bool avoidSixNum { get; set; } = true;
        public SortBy sortBy { get; set; } = SortBy.Normal;
        public double priceFrom { get; set; }
        public double priceTo { get; set; }
        public Guid userId { get; set; }
    }
    public class SearchSIMDataOnAppRequest : PagingRequestBase
    {
        public List<int>? productTypeIds { get; set; } = new List<int>();
        public SortBy sortBy { get; set; } = SortBy.Normal;
    }
    public class SearchSIMOfAgentOnAppRequest : PagingRequestBase
    {
        public Guid? userId { get; set; }
        public SimOnAppStatus? simOnAppStatus { get; set; }
        public SortBy? sortBy { get; set; } = SortBy.Normal;
    }

    //Agent filter
    public class AgentFilterRequest : PagingRequestBase
    {
        public bool isAgent { get; set; }
        public bool isConsignmentAgent { get; set; }
        public string? agentAcc { get; set; }
        public List<int>? agentGroup { get; set; }
    }
    //Order filter
    public class OrderFilterRequest : PagingRequestBase
    {
        public bool isMyOrder { get; set; }
        public string? userId { get; set; }
        public StatusOrder? statusOrder { get; set; }
        public List<string>? agents { get; set; }
    }

    // Tìm Sim
    public class TimSimRequest
    {
        public SearchType searchType { get; set; }
        public string keyword { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }

}
