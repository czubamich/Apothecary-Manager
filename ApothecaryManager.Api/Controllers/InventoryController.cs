﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ApothecaryManager.Data;
using Microsoft.AspNetCore.Authorization;
using ApothecaryManager.Data.Model;
using ApothecaryManager.Api.Models;

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

        public InventoryController(ShopDbContext context)
        {
            _context = context;
        }

        // GET: api/<AccountController>
        [HttpGet("all")]
        public Inventory GetAll()
        {
            throw new NotImplementedException();
        }

        // GET: api/<AccountController>
        [HttpGet("{id}")]
        public Inventory Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] InventoryModel item)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{Id}")]
        public void Put(int id, [FromBody] InventoryModel item)
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
