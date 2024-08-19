namespace cuahangbanle.DBData.Models
{
    public class DsQuyen
    {
        public string Manhomquyen { get; set; }
        public string Maquyen { get; set; }

        public Nhomquyen Nhomquyen { get; set; }
        public Quyen Quyen { get; set; }
    }
}
