using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Models
{
    public class SupplierModel
    {
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
    }
}
