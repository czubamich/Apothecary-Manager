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
        public long Name { get; set; }
        public long Phone { get; set; }
        public long Adress { get; set; }
    }
}
