using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Models
{
    public class RefreshToken
    {
        public Guid Id;
        public string Token;
        public int UserId;
    }
}
