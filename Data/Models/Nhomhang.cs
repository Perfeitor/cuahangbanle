using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.Data.Models
{
    [Table("Nhomhang")]
    public class Nhomhang
    {
            public string Manhomhang { get; set; } = "";
            public string Tennhomhang { get; set; } = "";
            public DateTime Ngaytao { get; set; }
            public string Nguoitao { get; set; } = "";
            public DateTime? Ngaysua { get; set; }
            public string? Nguoisua { get; set; }
    }

}
