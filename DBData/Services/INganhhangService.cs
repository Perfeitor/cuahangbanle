using cuahangbanle.DBData.Models;

namespace cuahangbanle.DBData.Services
{
    public interface INganhhangService
    {
        Task<List<Nganhhang>> GetAllNganhhang();
    }
}
