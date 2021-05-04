using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApothecaryManager.Data.Model
{
    [Table(name: "Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [JsonIgnore]
        [Column(TypeName = "varchar(50)")]
        public string Username { get; set; }

        [JsonIgnore]
        [Column(TypeName = "varbinary(64)")]
        public byte[] PasswordHash { get; set; }

        [JsonIgnore]
        [Column(TypeName = "varbinary(128)")]
        public byte[] PasswordSalt { get; set; }

        [JsonIgnore]
        [Column(TypeName = "varchar(50)")]
        public string Level { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string License { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Phone { get; set; }

        [JsonIgnore]
        [InverseProperty("SoldBy")]
        public ICollection<Sale> Sales { get; set; }
    }
}
