using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Models
{
    public class PrescriptionModel
    {
        [Required]
        public string BarCode { get; set; }

        [Required]
        public string Patient { get; set; }

        [Required]
        public string Issuer { get; set; }

        [Required]
        public string PWZ { get; set; }

        public string Phone { get; set; }
    }
}
