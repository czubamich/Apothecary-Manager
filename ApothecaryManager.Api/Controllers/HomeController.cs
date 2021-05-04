using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApothecaryManager.WebApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace ApothecaryManager.WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api")]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        [HttpGet("version")]
        public String GetVersion()
        {
            //TODO: Return server version
            throw new NotImplementedException();
        }

        [AllowAnonymous]
        [HttpGet("now")]
        public DateTime GetTimeNow()
        {
            return DateTime.Now;
        }

        [AllowAnonymous]
        [HttpGet("status")]
        public DateTime GetStatus()
        {
            //TODO: Check if logged in
            throw new NotImplementedException();
        }
    }
}
