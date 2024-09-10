using cuahangbanle.DBData.Models;

namespace cuahangbanle.DBData.Services
{
    public interface IMathangService
    {
        Task AddMathang(Mathang mathang);
        Task DeleteMathang(Mathang mathang);
        Task EditMathang(Mathang mathang);
        Task<List<Mathang>> GetAllMathang();
    }
}
