using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.DBData.Models
{
    public class Taikhoan
    {
        public string MaTK { get; set; }
        public string TenTk { get; set; }
        public string Manhomquyen { get; set; }
        public string Nguoitao { get; set; }
        public DateTime Ngaytao { get; set; }
        public string? Nguoisua { get; set; }
        public DateTime? Ngaysua { get; set; }

        public Nhomquyen Nhomquyen { get; set; }
    }
}
