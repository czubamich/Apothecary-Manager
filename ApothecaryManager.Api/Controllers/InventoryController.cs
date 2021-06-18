using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ApothecaryManager.Data;
using Microsoft.AspNetCore.Authorization;
using ApothecaryManager.Data.Model;
using ApothecaryManager.Api.Models;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApothecaryManager.WebApi.Controllers
{
    //TODO: Inventory controller
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly ShopDbContext _context;
        private readonly IMapper _mapper;

        public InventoryController(ShopDbContext context, IMapper mapper)
        {
            _context = context;
        }

        // GET: api/<AccountController>
        [HttpGet("all")]
        public IEnumerable<Inventory> GetAll()
        {
            var buffer = new List<Inventory>();

            foreach (var inventory in _context.Inventories)
            {
                buffer.Add(inventory);
            }

            return buffer;
        }

        // GET: api/<AccountController>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var element = _context.Inventories.First(x => x.Id == id);

            if (element == null)
                return NotFound();

            return Ok(element);
        }

        // POST api/<AccountController>
        [HttpPost]
        public IActionResult Post([FromBody] InventoryModel item)
        {
            var val = _mapper.Map<InventoryModel, Inventory>(item);

            _context.Inventories.Add(val);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut("{Id}")]
        public IActionResult Put(int id, [FromBody] InventoryModel item)
        {
            var val = _mapper.Map<InventoryModel, Inventory>(item);
            var element = _context.Inventories.First(x => x.Id == id);

            if (id == null)
                return NotFound();


            _context.SaveChanges();

            return Ok();
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var element = _context.Inventories.First(x => x.Id == id);
            if (element == null)
                return NotFound();

            _context.Inventories.Remove(element);
            _context.SaveChanges();

            return Ok();
        }
    }
}
