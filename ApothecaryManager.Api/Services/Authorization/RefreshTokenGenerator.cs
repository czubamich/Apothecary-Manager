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
    public class RefreshTokenGenerator
    {
        private readonly AuthenticationConfiguration _configuration;
        private readonly TokenGenerator _generator;

        public RefreshTokenGenerator(AuthenticationConfiguration configuration, TokenGenerator generator)
        {
            _configuration = configuration;
            _generator = generator;
        }

        public string GenerateToken()
        {
            return _generator.GenerateToken(
                _configuration.RefreshTokenSecret,
                _configuration.Issuer,
                _configuration.Audience,
                _configuration.RefreshTokenExpirationInMinutes);
        }
    }
}
