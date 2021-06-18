using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.WPF.Models
{
    class AuthenticatedUser
    {
        public int userId { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
