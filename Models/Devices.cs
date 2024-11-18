using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedManagement.Models
{
    [Table("Devices")]
    public class Device
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("DeviceName", TypeName = "NVARCHAR(100)")]
        public string DeviceName { get; set; }

        [Column("IPAddress", TypeName = "NVARCHAR(50)")]
        public string IPAddress { get; set; }

        [Column("Status", TypeName = "NVARCHAR(50)")]
        public string Status { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
