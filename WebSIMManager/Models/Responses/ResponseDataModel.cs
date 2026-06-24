using Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Responses
{
    //API
    public class ResponseDataPagingModel<T>
    {
        public string? Code { get; set; }
        public string? Message { get; set; }
        public Pager? Pager { get; set; }
        public List<T>? Data { get; set; }
    }


    public class ResponseDataModel<T>
    {
        public string? Code { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
    }
    public class ResponseDataViewModel<T>
    {
        public Pager Pager { get; set; }
        public List<T> Data { get; set; }
    }
    public class Pager
    {
        public PagingRequestBase Key { get; set; }
        public int CurrentPage { get; set; }
        public int TotalRecords { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }

        public Pager()
        {
        }
        public Pager(PagingRequestBase key, int totalRecords)
        {
            int totalPages = 1;
            if (key.pageSize > 0)
            {
                totalPages = (int)Math.Ceiling((decimal)totalRecords / (decimal)key.pageSize);
            }
            int startPage = key.pageIndex - 2;
            int endPage = key.pageIndex + 2;
            if (startPage <= 0)
            {
                endPage = endPage - (startPage - 1);
                startPage = 1;
            }
            if (endPage > totalPages)
            {
                endPage = totalPages;

            }
            //

            CurrentPage = key.pageIndex;
            TotalRecords = totalRecords;
            PageSize = key.pageSize;
            TotalPages = totalPages;
            StartPage = startPage;
            EndPage = endPage;
            this.Key = key;
        }
    }
}
