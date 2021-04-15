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
    public class User
    {
        [Key]
        public long ID { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(50000)")]
        public string Password { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Level { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string License { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Phone { get; set; }
    }
}
