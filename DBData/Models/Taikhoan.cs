using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.DBData.Models
{
    [Table("Taikhoan")]
    public class Taikhoan
    {
        public string MaTK { get; set; } = "";
        public string TenTk { get; set; } = "";
        public string Matkhau { get; set; } = "";
        public string Manhomquyen { get; set; } = "";
        public string? Manguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string? Manguoisua { get; set; }
        public DateTime? Ngaysua { get; set; }

        public Nhomquyen Nhomquyen { get; set; } = new();
    }
}
