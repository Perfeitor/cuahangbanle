namespace cuahangbanle.DBData.Models
{
    public class Nhomquyen
    {
        public string Manhomquyen { get; set; }
        public string Tennhomquyen { get; set; }

        public ICollection<DsQuyen>? DsQuyens { get; set; }
    }
}
