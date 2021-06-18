using ApothecaryManager.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.WPF.Services.Interfaces
{
    interface ISessionService
    {
        bool LoggedIn { get; }
        User LoggedUser { get; }

        void Setup();
        bool Login(string username, string password);
        bool Refresh();
        bool Logout();
    }
}
