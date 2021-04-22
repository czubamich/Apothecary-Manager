using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.Data.Model
{
    [Table(name: "Drugs")]
    public class Drug
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string ActiveSubstance { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string Description { get; set; }

        [ForeignKey("Category")]
        public int CategoryRefId { get; set; }
        public Category Category { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Unit { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string QuantityInPackage { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Dose { get; set; }

        [Column(TypeName = "varchar(50)")]
        public bool IsPrescribed { get; set; }
    }
}
