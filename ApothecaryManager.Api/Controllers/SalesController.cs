using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ApothecaryManager.Data;
using Microsoft.AspNetCore.Authorization;
using ApothecaryManager.Data.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApothecaryManager.WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class SalesController : ControllerBase
    {
        private readonly ShopDbContext _context;

        public SalesController(ShopDbContext context)
        {
            _context = context;
        }

        // GET: api/<AccountController>
        [HttpGet("all")]
        public Sale GetAll()
        {
            throw new NotImplementedException();
        }

        // GET: api/<AccountController>
        [HttpGet("{id}")]
        public Sale Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] Sale item)
        {
            throw new NotImplementedException();
        }

        // POST api/<AccountController>/ID
        [HttpPut]
        public void Put(int id,[FromBody] Sale item)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
