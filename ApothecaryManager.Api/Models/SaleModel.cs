using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Models
{
    public class SaleModel
    {
        [Required]
        public int SoldByRefId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public bool isRefundable { get; set; }

        [Required]
        public ICollection<SaleDetailModel> SaleDetails { get; set; }
    }
}
