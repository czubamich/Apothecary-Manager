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
        public ActionResult<CategoryResponse> Get(int id)
        {
            var cat = _context.Categories.First(x => x.Id == id);

            if (cat == null)
                return NotFound();

            return Ok(new CategoryResponse()
            {
                Id = cat.Id,
                Name = cat.Name,
                Drugs = cat.DrugsInCategory,
            });
        }

        // POST api/<AccountController>
        [HttpPost]
        public IActionResult Post([FromBody] string item)
        {
            _context.Categories.Add(
                new Category()
                {
                    Name = item
                });
            _context.SaveChanges();

            return Ok();
        }

        // PUT api/<AccountController>/5
        [HttpPut("{Id}")]
        public IActionResult Put(int id, [FromBody] string item)
        {
            var element = _context.Categories.First(x => x.Id == id);
            if (x == null)
                return NotFound();

            element.Name = item;
            _context.SaveChanges();

            return Ok();
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var element = _context.Categories.First(x => x.Id == id);
            if (x == null)
                return NotFound();

            _context.Categories.Remove(element);
            _context.SaveChanges();

            return Ok();
        }
    }
}
