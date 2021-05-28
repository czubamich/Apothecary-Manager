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
    public class DrugController : ControllerBase
    {
        private readonly ShopDbContext _context;
        private readonly IMapper _mapper;

        public DrugController(ShopDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<AccountController>
        [HttpGet("all")]
        public IEnumerable<Drug> GetAll()
        {
            var buffer = new List<Drug>();

            foreach (var drug in _context.Drugs)
            {
                buffer.Add(drug);
            }

            return buffer;
        }

        // GET: api/<AccountController>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var drug = _context.Categories.First(x => x.Id == id);

            if (drug == null)
                return NotFound();

            return Ok(drug);
        }

        // POST api/<AccountController>
        [HttpPost]
        public IActionResult Post([FromBody] DrugModel item)
        {
            var val = _mapper.Map<DrugModel, Drug>(item);

            _context.Drugs.Add(val);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut("{Id}")]
        public IActionResult Put(int id, [FromBody] DrugModel item)
        {
            var val = _mapper.Map<DrugModel, Drug>(item);
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
            var element = _context.Drugs.First(x => x.Id == id);
            if (element == null)
                return NotFound();

            _context.Drugs.Remove(element);
            _context.SaveChanges();

            return Ok();
        }
    }
}
