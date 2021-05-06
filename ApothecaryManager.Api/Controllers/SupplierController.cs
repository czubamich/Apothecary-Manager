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
        public void Post([FromBody] SupplierModel item)
        {
            Supplier val = _mapper.Map<SupplierModel, Supplier>(item);

            throw new NotImplementedException();
        }

        [HttpPut("{Id}")]
        public void Put(int id, [FromBody] SupplierModel item)
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
