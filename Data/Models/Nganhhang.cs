using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.DBData.Models
{
    [Table("Nganhhang")]
    public class Nganhhang
    {
        public string Manganhhang { get; set; } = "";
        public string Tennganghang { get; set; } = "";
        public DateTime Ngaytao { get; set; }
        public string Nguoitao { get; set; } = "";
        public DateTime? Ngaysua { get; set; }
        public string? Nguoisua { get; set; }
    }
}
