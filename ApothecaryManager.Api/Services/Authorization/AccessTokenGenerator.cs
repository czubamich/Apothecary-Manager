using ApothecaryManager.Api.Helpers;
using ApothecaryManager.Data.Model;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Services
{
    public class AccessTokenGenerator
    {
        private readonly AuthenticationConfiguration _configuration;
        private readonly TokenGenerator _generator;

        public AccessTokenGenerator(AuthenticationConfiguration configuration, TokenGenerator generator)
        {
            _configuration = configuration;
            _generator = generator;
        }

        public string GenerateToken(User user)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Id.ToString())
            };

            return _generator.GenerateToken(
                _configuration.AccessTokenSecret,
                _configuration.Issuer,
                _configuration.Audience,
                _configuration.AccessTokenExpirationInMinutes,
                claims
                );
        }
    }
}
