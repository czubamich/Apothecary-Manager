using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ApothecaryManager.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApothecaryManager.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly ShopDbContext _context;

        public InventoryController(ShopDbContext context)
        {
            _context = context;
        }

        // GET: api/<AccountController>
        [HttpGet("token")]
        public IEnumerable<string> GetToken()
        {
            return new string[] { "value1", "value2", _context.Categories.Count().ToString()};
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
