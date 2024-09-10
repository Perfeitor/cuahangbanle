using cuahangbanle.DBData.Models;

namespace cuahangbanle.DBData.Services
{
    public interface IDonhangService
    {
        Task<List<Donhang>> GetAllDonhang();
    }
}
