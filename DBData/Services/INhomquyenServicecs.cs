using cuahangbanle.DBData.Models;

namespace cuahangbanle.DBData.Services
{
    public interface INhomquyenServicecs
    {
        Task<List<Nhomquyen>> GetAllNhomquyen();
    }
}
