using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreFirst.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [StringLength(5, MinimumLength = 5)]
        [Key]
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        [MaxLength(11)]
        public string SoDT { get; set; }
        public string Email { get; set; }
    }
}
