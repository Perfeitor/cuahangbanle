using cuahangbanle.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.DBData.Models
{
    [Table("Mathang")]
    public class Mathang
    {
        public string Mamathang { get; set; } = "";
        public string Manganhhang { get; set; } = "";
        public string Manhomhang { get; set; } = "";
        public string MaNCC { get; set; } = "";
        public string TenNCC { get; set; } = "";
        public string Tensanpham { get; set; } = "";
        public string Madonvitinh { get; set; } = "";
        public int Tonkho { get; set; }
        public decimal Gianhap { get; set; }
        public decimal Giaban { get; set; }
        public decimal Phantramlai { get; set; }
        public decimal Tienlai { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Nguoitao { get; set; } = "";
        public DateTime? Ngaysua { get; set; }
        public string? Nguoisua { get; set; }

        public Nganhhang? Nganhhang { get; set; }
        public Nhomhang? Nhomhang { get; set; }
        public Nhacungcap? Nhacungcap { get; set; }
        public Donvitinh? Donvitinh { get; set; }
    }
}
