using cuahangbanle.Data.Models;

namespace cuahangbanle.Components.Services
{
    public interface INhomhangService
    {
        Task CreateNhomhang(Nhomhang nhom);
        Task<List<Nhomhang>> GetAllNhomhang();
        Task<Nhomhang> GetNhomhangById(string id);
        Task RemoveNhomhang(Nhomhang nhom);
        Task UpdateNhomhang(Nhomhang nhom);
    }
}
