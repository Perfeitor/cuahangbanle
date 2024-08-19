using cuahangbanle.DBData.Models;

namespace cuahangbanle.DBData.Services
{
    public interface IDonvitinhService
    {
        Task<List<Donvitinh>> GetAllDonvitinh();
    }
}
