using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.Data.Model
{
    [Table(name: "Inventories")]
    public class Inventory
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Drug")]
        public int DugyRefId { get; set; }
        public Drug Drug { get; set; }

        [ForeignKey("Supplier")]
        public int? SupplierRefId { get; set; }
        public Supplier Supplier { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string Batch { get; set; }

        [Column(TypeName = "date")]
        public DateTime ProductionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DeliveryDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpirationDate { get; set; }

        [Column(TypeName = "int")]
        public int QtyInStock { get; set; }

        [Column(TypeName = "float")]
        public float UnitPrice { get; set; }

        [Column(TypeName = "float")]
        public float Tax { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string Description { get; set; }
    }
}
