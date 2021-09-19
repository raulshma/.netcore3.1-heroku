using Microsoft.AspNetCore.Mvc;
using NorthwindApi.Data;
using NorthwindApi.Dtos;
using NorthwindApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NorthwindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController
    {
        public CategoryController(NorthwindContext context) : base(context) { }
        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<BaseResponse<Category>> Get(int page = 1, int pageSize = 20)
        {
            var result = _context.Categories.OrderBy(e=>e.CategoryId).AsQueryable();
            return await PagedResponse(page, pageSize, result);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{categoryId}")]
        public async Task<Category> Get(int categoryId)
        {
            return await _context.Categories.FindAsync(categoryId);
        }
    }
}
