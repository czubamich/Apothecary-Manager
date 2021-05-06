using ApothecaryManager.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Models.Responses
{
    public class CategoryResponse
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IEnumerable<Drug> Drugs { get; set; }
    }
}
