using cuahangbanle.Data;
using cuahangbanle.Data.Models;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.Components.Services
{
    public class NhomhangService : INhomhangService
    {
        private ApplicationDbContext _db;
        public NhomhangService(ApplicationDbContext db)
        {
            _db = db;
        }

        #region Get data
        public async Task<List<Nhomhang>> GetAllNhomhang()
        {
            return await _db.Nhomhangs.ToListAsync();
        }
        public async Task<Nhomhang> GetNhomhangById(string id)
        {
            return await _db.Nhomhangs.FirstOrDefaultAsync(n => n.Manhomhang == id) ?? new();
        }
        #endregion

        #region CUD
        public async Task RemoveNhomhang(Nhomhang nhom)
        {
            _db.Nhomhangs.Remove(nhom);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateNhomhang(Nhomhang nhom)
        {
            _db.Nhomhangs.Update(nhom);
            await _db.SaveChangesAsync();
        }
        public async Task CreateNhomhang(Nhomhang nhom)
        {

            await _db.Nhomhangs.AddAsync(nhom);
            await _db.SaveChangesAsync();
        }
        #endregion
    }
}
