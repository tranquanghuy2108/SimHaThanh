using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Requests
{
    public class PagedViewResult<T>
    {
        public List<T> Item { set; get; }
        public int TotalRecord { set; get; }
    }
}
