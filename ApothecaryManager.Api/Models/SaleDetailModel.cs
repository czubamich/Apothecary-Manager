using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Models
{
    public class SaleDetailModel
    {
        public int? PrescriptionId { get; set; }

        [Required]
        public int DrugRefId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float UnitPrice { get; set; }

        [Required]
        public float Discount { get; set; }

        [Required]
        public float Refund { get; set; }
    }
}
