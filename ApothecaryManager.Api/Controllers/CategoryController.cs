using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ApothecaryManager.Data;
using Microsoft.AspNetCore.Authorization;
using ApothecaryManager.Data.Model;
using ApothecaryManager.Api.Models.Responses;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApothecaryManager.WebApi.Controllers
{
    //TODO: Inventory controller
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ShopDbContext _context;

        public CategoryController(ShopDbContext context)
        {
            _context = context;
        }

        // GET: api/<AccountController>
        [HttpGet("all")]
        public IEnumerable<CategoryResponse> GetAll()
        {
            var buffer = new List<CategoryResponse>();

            foreach(var cat in _context.Categories)
            {
                buffer.Add(new CategoryResponse()
                {
                    Id = cat.Id,
                    Name = cat.Name,
                    Drugs = cat.DrugsInCategory,
                });
            }

            return buffer;
        }

        // GET: api/<AccountController>/5
        [HttpGet("{id}")]
        public CategoryResponse Get(int id)
        {
            var cat = _context.Categories.FirstOrDefault(x => x.Id == id);
            return new CategoryResponse()
            {
                Id = cat.Id,
                Name = cat.Name,
                Drugs = cat.DrugsInCategory,
            };
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] string item)
        {
            throw new NotImplementedException();
        }

        // PUT api/<AccountController>/5
        [HttpPut("{Id}")]
        public void Put(int id, [FromBody] string item)
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
