using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Helpers
{
    public class AuthenticationConfiguration
    {
        public string AccessTokenSecret { get; set; }
        public int AccessTokenExpirationInMinutes { get; set; }
        public string RefreshTokenSecret { get; set; }
        public int RefreshTokenExpirationInMinutes { get; set; }

        public string Issuer { get; set; }
        public string Audience { get; set; }

    }
}
