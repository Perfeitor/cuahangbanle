using cuahangbanle.DBData.Models;

namespace cuahangbanle.Components.Services
{
    public interface IMathangService
    {
        Task CreateMathang(Mathang mathang);
        Task<List<Mathang>> GetAllMathang();
        Task<Mathang> GetMathangById(string id);
        Task RemoveMathang(Mathang mathang);
        Task UpdateMathang(Mathang mathang);
    }
}
