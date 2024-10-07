using cuahangbanle.DBData.Models;

namespace cuahangbanle.Components.Services
{
    public interface IDonvitinhService
    {
        Task CreateDonvitinh(Donvitinh donvi);
        Task<List<Donvitinh>> GetAllDonvitinh();
        Task<Donvitinh> GetDonvitinhById(string id);
        Task RemoveDonvitinh(Donvitinh donvi);
        Task UpdateDonvitinh(Donvitinh donvi);
    }
}
