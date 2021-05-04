using ApothecaryManager.Api.Helpers;
using ApothecaryManager.Api.Models;
using ApothecaryManager.Data.Model;
using ApothecaryManager.WebApi.Helpers;
using ApothecaryManager.WebApi.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Controllers
{
    //TODO: Admin tools
    public class SecurityController : Controller
    {
        private IUserService _userService;
        private IMapper _mapper;

        public SecurityController(
            IUserService userService,
            IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
    }
}
