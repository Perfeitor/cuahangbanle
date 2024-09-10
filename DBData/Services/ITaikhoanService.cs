using cuahangbanle.DBData.Models;

namespace cuahangbanle.DBData.Services
{
    public interface ITaikhoanService
    {
        Task<List<Taikhoan>> GetAllTaikhoan();
    }
}
