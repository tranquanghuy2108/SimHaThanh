using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Requests
{
    public class PagingRequestBase
    {
        public bool isPaged { get; set; } = true;
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public string keyword { get; set; }
    }
}
