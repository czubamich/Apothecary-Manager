using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Models
{
    public class DrugModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ActiveSubstance { get; set; }

        [Required]
        public string Description { get; set; }

        public int? CategoryRefId { get; set; }

        [Required]
        public string Unit { get; set; }

        [Required]
        public string QuantityInPackage { get; set; }

        [Required]
        public string Dose { get; set; }

        [Required]
        public bool IsPrescribed { get; set; }
    }
}
