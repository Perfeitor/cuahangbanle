using cuahangbanle.DBData.Models;

namespace cuahangbanle.Components.Services
{
    public interface INganhhangService
    {
        Task CreateNganhhang(Nganhhang nganh);
        Task<List<Nganhhang>> GetAllNganhhang();
        Task<Nganhhang> GetNganhhangById(string id);
        Task RemoveNganhhang(Nganhhang nganh);
        Task UpdateNganhhang(Nganhhang nganh);
    }
}
