using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.DBData.Models
{
    [Table("DsMatHang")]
    public class DsMatHang
    {
        public string Madonhang { get; set; } = "";
        public string Mamathang { get; set; } = "";

        public Donhang Donhang { get; set; } = new();
        public Mathang Mathang { get; set; } = new();
    }
}
