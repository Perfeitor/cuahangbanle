using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.DBData.Models
{
    [Table("Quyen")]
    public class Quyen
    {
        public string Maquyen { get; set; } = "";
        public string Tenquyen { get; set; } = "";
        public string? Mota { get; set; }

        public ICollection<DsQuyen>? DsQuyens { get; set; }
    }
}
