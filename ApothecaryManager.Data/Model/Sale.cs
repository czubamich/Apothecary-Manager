using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.Data.Model
{
    [Table(name: "Sales")]
    class Sale
    {
        [Key]
        public long ID { get; set; }

        [ForeignKey("User")]
        public int UserRefId { get; set; }
        public User User { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string State { get; set; }

        [Column(TypeName = "varchar(50)")]
        public bool isRefundable { get; set; }
    }
}
