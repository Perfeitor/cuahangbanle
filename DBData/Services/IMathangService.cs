using cuahangbanle.DBData.Models;

namespace cuahangbanle.DBData.Services
{
    public interface IMathangService
    {
        Task<List<Mathang>> GetAllMathang();
    }
}
