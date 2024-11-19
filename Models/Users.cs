using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedManagement.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("UserName", TypeName = "NVARCHAR(100)")]
        public required string UserName { get; set; }

        [Required]
        [Column("PasswordHash", TypeName = "NVARCHAR(200)")]
        public required string PasswordHash { get; set; }

        [Required]
        [Column("Role", TypeName = "NVARCHAR(50)")]
        public required string Role { get; set; }
    }
}
