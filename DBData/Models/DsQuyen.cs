using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.DBData.Models
{
    [Table("DsQuyen")]
    public class DsQuyen
    {
        public string Manhomquyen { get; set; } = "";
        public string Maquyen { get; set; } = "";

        public Nhomquyen Nhomquyen { get; set; } = new();
        public Quyen Quyen { get; set; } = new();
    }
}
