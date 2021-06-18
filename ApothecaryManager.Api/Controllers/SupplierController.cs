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
    //TODO: Futher data validation
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly ShopDbContext _context;
        private readonly IMapper _mapper;

        public SupplierController(ShopDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<AccountController>
        [HttpGet("all")]
        public IEnumerable<Supplier> GetAll()
        {
            return _context.Suppliers.AsEnumerable();
        }

        // GET: api/<AccountController>
        [HttpGet("{id}")]
        public Supplier Get(int id)
        {
            return _context.Suppliers.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<AccountController>
        [HttpPost]
        public IActionResult Post([FromBody] SupplierModel item)
        {
            var val = _mapper.Map<SupplierModel, Supplier>(item);

            _context.Suppliers.Add(val);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut("{Id}")]
        public IActionResult Put(int id, [FromBody] SupplierModel item)
        {
            var val = _mapper.Map<SupplierModel, Supplier>(item);
            var element = _context.Drugs.First(x => x.Id == id);
            if (element == null)
                return NotFound();

            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var element = _context.Suppliers.First(x => x.Id == id);
            if (element == null)
                return NotFound();

            _context.Suppliers.Remove(element);
            _context.SaveChanges();

            return Ok();
        }
    }
}
