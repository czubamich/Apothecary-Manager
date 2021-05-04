using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Models
{
    public class InventoryModel
    {
        [Required]
        public int DrugRefId { get; set; }

        [Required]
        public int? SupplierRefId { get; set; }

        [Required]
        public string Batch { get; set; }

        public DateTime ProductionDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int QtyInStock { get; set; }

        public float UnitPrice { get; set; }

        public float Tax { get; set; }

        public string Description { get; set; }
    }
}
