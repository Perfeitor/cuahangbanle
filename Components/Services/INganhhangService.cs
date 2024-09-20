using cuahangbanle.DBData.Models;

namespace cuahangbanle.Components.Services
{
    public interface INganhhangService
    {
        Task<List<Nganhhang>> GetAllNganhhang();
    }
}
