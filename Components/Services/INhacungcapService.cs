using cuahangbanle.DBData.Models;

namespace cuahangbanle.Components.Services
{
    public interface INhacungcapService
    {
        Task CreateNhacungcap(Nhacungcap nhacungcap);
        Task<List<Nhacungcap>> GetAllNhacungcap();
        Task<Nhacungcap> GetNhacungcapById(string id);
        Task RemoveNhacungcap(Nhacungcap nhacungcap);
        Task UpdateNhacungcap(Nhacungcap nhacungcap);
    }
}
