using cuahangbanle.DBData.Models;

namespace cuahangbanle.DBData.Services
{
    public interface INhacungcapService
    {
        Task<List<Nhacungcap>> GetAllNhacungcap();
    }
}
