using cuahangbanle.DBData.Models;

namespace cuahangbanle.Components.Services
{
    public interface IDonhangService
    {
        Task CreateDonhang(Donhang donhang);
        Task CreateDsMathang(DsMatHang ds);
        Task<List<Donhang>> GetAllDonhang();
        Task<Donhang> GetDonhangById(string id);
        Task<List<DsMatHang>> GetDsMathangByDonhangId(string id);
        Task RemoveDonhang(Donhang donhang);
        Task UpdateDonhang(Donhang donhang);
    }
}
