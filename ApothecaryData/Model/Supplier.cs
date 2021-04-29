using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.Data.Model
{
    [Table(name: "Suppliers")]
    public class Supplier
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "varchar(50)")]
        public long Name { get; set; }

        [Column(TypeName = "varchar(50)")]
        public long Phone { get; set; }

        [Column(TypeName = "varchar(50)")]
        public long Adress { get; set; }

        public List<Drug> Deliveries { get; set; }
    }
}
