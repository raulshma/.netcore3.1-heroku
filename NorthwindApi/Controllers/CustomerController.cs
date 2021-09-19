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
    public class CustomerController : BaseController
    {
        public CustomerController(NorthwindContext context) : base(context) { }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<BaseResponse<Customer>> Get(int page = 1, int pageSize = 20)
        {
            var result = _context.Customers.OrderBy(e=>e.CustomerId).AsQueryable();
            return await PagedResponse(page, pageSize, result);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{customerId}")]
        public async Task<Customer> Get(int customerId)
        {
            return await _context.Customers.FindAsync(customerId);
        }
    }
}
