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
    [Table(name: "DrugsBase")]
    public class DrugBase
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string QtyInStock { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string QtyOnOrder { get; set; }

        public string Category { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string QuantityInPackage { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Price { get; set; }
    }
}
