using ApothecaryManager.Api.Models;
using ApothecaryManager.Api.Services;
using ApothecaryManager.Api.Services.Interfaces;
using ApothecaryManager.Data.Model;
using ApothecaryManager.WebApi.Helpers;
using ApothecaryManager.WebApi.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkId=397860

namespace ApothecaryManager.WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class IdentityController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;
        private RefreshTokenValidator _refreshTokenValidator;
        private AuthenticationService _authenticationService;
        private IRefreshTokenRepository _refreshTokenRepository;

        public IdentityController(IUserService userService, IMapper mapper, RefreshTokenValidator refreshTokenValidator, AuthenticationService authenticationService, IRefreshTokenRepository refreshTokenRepository)
        {
            _userService = userService;
            _mapper = mapper;
            _refreshTokenValidator = refreshTokenValidator;
            this._authenticationService = authenticationService;
            _refreshTokenRepository = refreshTokenRepository;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateModel model)
        {
            var user = _userService.Authenticate(model.Username, model.Password);
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            var response = await _authenticationService.Authenticate(user);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody] RefreshModel refreshModel)
        {
            bool isValidRefreshToken = _refreshTokenValidator.Validate(refreshModel.RefreshToken);
            if(!isValidRefreshToken)
            {
                return BadRequest();
            }

            var refreshToken = await _refreshTokenRepository.GetByToken(refreshModel.RefreshToken);
            if(refreshToken == null)
            {
                return Unauthorized();
            }

            User user = _userService.GetById(refreshToken.UserId);
            await _refreshTokenRepository.Delete(refreshToken.Id);

            var response = await _authenticationService.Authenticate(user);

            return Ok(response);
        }

        [HttpDelete("logout")]
        public async Task<IActionResult> Logout()
        {
            string id = HttpContext.User.Identity.Name;

            if (!int.TryParse(id, out int userId))
            {
                return Unauthorized();
            }

            await _refreshTokenRepository.DeleteAll(userId);

            return Ok();
        }

        [HttpPost("register")]
        [Authorize(Roles = "Administrators")]
        public IActionResult Register([FromBody] RegisterModel model)
        {
            // map model to entity
            var user = _mapper.Map<User>(model);

            try
            {
                // create user
                _userService.Create(user, model.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            var model = _mapper.Map<IList<UserModel>>(users);
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            var model = _mapper.Map<UserModel>(user);
            return Ok(model);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateModel model)
        {
            // map model to entity and set id
            var user = _mapper.Map<User>(model);
            user.Id = id;

            try
            {
                // update user
                _userService.Update(user, model.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok();
        }
    }
}