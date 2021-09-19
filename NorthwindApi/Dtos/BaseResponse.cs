using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindApi.Dtos
{
    public class BaseResponse<T>
    {
        public BaseResponse()
        {
        }
        public BaseResponse(List<T> data, int page = 1, int pageSize = 20, bool hasMore = false, bool isSuccess = true, string message = "")
        {
            Succeeded = isSuccess;
            Message = message;
            Paging = new Paging { Page = page, PageSize = pageSize, HasMore = hasMore };
            Errors = null;
            Data = data;
        }
        public List<T> Data { get; set; }
        public Paging Paging { get; set; }
        public bool Succeeded { get; set; }
        public string[] Errors { get; set; }
        public string Message { get; set; }
    }
}
