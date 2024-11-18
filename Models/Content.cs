using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedManagement.Models
{
    [Table("Content")]
    public class Content
    {
        [Key]
        public int Id { get; set; }

        [Column("ContentName", TypeName = "NVARCHAR(200)")]
        public string ContentName { get; set; }

        [Column("FilePath", TypeName = "NVARCHAR(500)")]
        public string FilePath { get; set; }

        [Column("DisplayDuration")]
        public int DisplayDuration { get; set; }
    }
}
