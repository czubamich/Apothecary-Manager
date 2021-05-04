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
    [Table(name: "Sales")]
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [JsonIgnore]
        public int SoldByRefId { get; set; }
        public User SoldBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string State { get; set; }

        [Column(TypeName = "varchar(50)")]
        public bool isRefundable { get; set; }

        public ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
