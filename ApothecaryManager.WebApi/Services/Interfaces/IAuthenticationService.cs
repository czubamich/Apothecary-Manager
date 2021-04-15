using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.WebApi.Services.Interfaces
{
    public interface IAuthenticationService
    {
        bool Login(string username, string password);
    }
}
