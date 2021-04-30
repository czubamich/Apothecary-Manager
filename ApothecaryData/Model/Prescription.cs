using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApothecaryManager.Data.Model
{
    [Table(name: "Prescriptions")]
    public class Prescription
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(5000)")]
        [Required]
        public string BarCode { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Patient { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Issuer { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string PWZ { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Phone { get; set; }
    }
}
