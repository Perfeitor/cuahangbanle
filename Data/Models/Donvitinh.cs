using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.DBData.Models
{
    [Table("Donvitinh")]
    public class Donvitinh
    {
        public string Madonvitinh { get; set; } = "";
        public string Donvile { get; set; } = "";
        public string Donvilon { get; set; } = "";
        public DateTime Ngaytao { get; set; }
        public string Nguoitao { get; set; } = "";
        public DateTime? Ngaysua { get; set; }
        public string? Nguoisua { get; set; }
    }
}
