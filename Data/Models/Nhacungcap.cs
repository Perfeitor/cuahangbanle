using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.DBData.Models
{
    [Table("Nhacungcap")]
    public class Nhacungcap
    {
        public string MaNCC { get; set; } = "";
        public string TenNCC { get; set; } = "";
        public string? Diachi { get; set; }
        public string? Dienthoai { get; set; }
        public string? Email { get; set; }
        public string Nguoitao { get; set; } = "";
        public DateTime Ngaytao { get; set; }
        public string? Nguoisua { get; set; }
        public DateTime? Ngaysua { get; set; }
    }
}
