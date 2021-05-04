using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Models
{
    public class RefreshModel
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}
