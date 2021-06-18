using ApothecaryManager.Data.Model;
using ApothecaryManager.WPF.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.WPF.Services
{
    class SessionService : ISessionService
    {
        string RefreshToken { get; set; }
        string AccessToken { get; set; }

        public bool LoggedIn => throw new NotImplementedException();
        public User LoggedUser => throw new NotImplementedException();

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Logout()
        {
            throw new NotImplementedException();
        }

        public bool Refresh()
        {
            throw new NotImplementedException();
        }

        public void Setup()
        {
            throw new NotImplementedException();
        }
    }
}
