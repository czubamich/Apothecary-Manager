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
    [Table(name: "Categories")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Name { get; set; }

        [InverseProperty("Category")]
        [JsonIgnore]
        public virtual ICollection<Drug> DrugsInCategory { get; set; }
    }
}
