using MedManagement.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedManagement.Models
{
    [Table("DeviceStatus")]
    public class DeviceStatus
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Device")]
        public int DeviceId { get; set; }

        [Column("Status", TypeName = "NVARCHAR(50)")]
        public string Status { get; set; }

        public DateTime LastChecked { get; set; }

        // Thiết lập quan hệ với lớp Device
        public virtual Device Device { get; set; }
    }
}
