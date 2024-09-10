using System.ComponentModel.DataAnnotations.Schema;

namespace cuahangbanle.DBData.Models
{
    [Table("Nhomquyen")]
    public class Nhomquyen
    {
        public string Manhomquyen { get; set; } = "";
        public string Tennhomquyen { get; set; } = "";

        public ICollection<DsQuyen>? DsQuyens { get; set; }
    }
}
