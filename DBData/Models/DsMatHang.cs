namespace cuahangbanle.DBData.Models
{
    public class DsMatHang
    {
        public string Madonhang { get; set; }
        public string Mamathang { get; set; }

        public Donhang Donhang { get; set; }
        public Mathang Mathang { get; set; }
    }
}
