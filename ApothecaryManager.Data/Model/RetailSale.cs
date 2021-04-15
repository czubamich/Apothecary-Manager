using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.Data.Model
{
    [Table(name: "RetailSales")]
    public class RetailSale
    {
        [Key]
        public long ID { get; set; }

        [ForeignKey("Sale")]
        public int SaleRefId { get; set; }
        public Sale Sale { get; set; }

        [ForeignKey("Prescription")]
        public int PrescriptionRefId { get; set; }
        public Prescription Prescription { get; set; }

        [ForeignKey("Drug")]
        public int DrugRefId { get; set; }
        public Sale Drug { get; set; }

        [Column(TypeName = "int")]
        public int Quantity { get; set; }

        [Column(TypeName = "float")]
        public float UnitPrice { get; set; }

        [Column(TypeName = "float")]
        public float Discount { get; set; }

        [Column(TypeName = "float")]
        public float Refund { get; set; }
    }
}
