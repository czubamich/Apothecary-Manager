using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApothecaryManager.Data.Model
{
    [Table(name: "SaleDetails")]
    public class SaleDetail
    {
        [Key]
        public int Id { get; set; }

        [JsonIgnore]
        [ForeignKey("Prescription")]
        public int? PrescriptionRefId { get; set; }
        public Prescription Prescription { get; set; }

        [JsonIgnore]
        [ForeignKey("Drug")]
        [Required]
        public int DrugRefId { get; set; }
        public Drug Drug { get; set; }

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
