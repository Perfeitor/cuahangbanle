using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.DBData.Models
{
    [Table("Donhang")]
    public class Donhang
    {
        public string Madonhang { get; set; } = "";
        public DateTime? Ngaytao { get; set; }
        public string? Nguoitao { get; set; }
        public bool Kieudonhang { get; set; }
        public decimal? Tienhang { get; set; }
        public decimal? Tientralai { get; set; }

    }
}
