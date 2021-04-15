using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.Data.Model
{
    [Table(name: "Users")]
    class User
    {
        [Key]
        public long ID { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public long Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public long Phone { get; set; }
    }
}
