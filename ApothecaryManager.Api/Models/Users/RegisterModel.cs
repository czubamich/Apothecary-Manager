using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Models
{
    public class UpdateModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string License { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
