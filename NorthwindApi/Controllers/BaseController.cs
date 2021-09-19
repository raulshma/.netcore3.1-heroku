using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NorthwindApi.Data;
using NorthwindApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace NorthwindApi.Controllers
{
    public class BaseController : ControllerBase
    {
        protected readonly NorthwindContext _context;

        public BaseController(NorthwindContext context)
        {
            _context = context;
        }

        public async static Task<BaseResponse<T>> PagedResponse<T>(int page, int pageSize, IQueryable<T> list = null)
        {
            if (list == null)
            {
                return new BaseResponse<T>(null, isSuccess: false, message: "No records found");
            }

            var count = await list.CountAsync();
            var items = await list.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            BaseResponse<T> response = new BaseResponse<T>(items, page, pageSize);
            if (items.Count <= pageSize && items.Count < count) response.Paging.HasMore = true;
            return response;
        }
    }
}
