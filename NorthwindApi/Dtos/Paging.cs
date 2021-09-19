using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindApi.Dtos
{
    public class Paging
    {
        public bool HasMore { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
