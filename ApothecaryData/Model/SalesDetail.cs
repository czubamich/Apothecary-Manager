using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.Data.Model
{
    [Table(name: "SalesDetail")]
    public class SalesDetail
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Prescription")]
        public int? PrescriptionRefId { get; set; }
        public Prescription Prescription { get; set; }

        [ForeignKey("Drug")]
        [Required]
        public int DrugRefId { get; set; }
        public Sale Drug { get; set; }

        public int SaleRefId { get; set; }
        public Sale Sale { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Quantity { get; set; }

        [Column(TypeName = "float")]
        [Required]
        public float UnitPrice { get; set; }

        [Column(TypeName = "float")]
        [Required]
        public float Discount { get; set; }

        [Column(TypeName = "float")]
        [Required]
        public float Refund { get; set; }
    }
}
