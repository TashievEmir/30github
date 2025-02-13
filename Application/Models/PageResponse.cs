using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class PageResponse<T>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public long TotalPages { get; set; }
        public long TotalCount { get; set; }
        public List<T> Content { get; set; }
    }
}
