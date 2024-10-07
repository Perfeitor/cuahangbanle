using cuahangbanle.Data.Models;
using cuahangbanle.Data;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.Components.Services
{
    public class NhacungcapService : INhacungcapService
    {
        private ApplicationDbContext _db;
        public NhacungcapService(ApplicationDbContext db)
        {
            _db = db;
        }

        #region Get data
        public async Task<List<Nhacungcap>> GetAllNhacungcap()
        {
            return await _db.Nhacungcaps.ToListAsync();
        }
        public async Task<Nhacungcap> GetNhacungcapById(string id)
        {
            return await _db.Nhacungcaps.FirstOrDefaultAsync(n => n.MaNCC == id) ?? new();
        }
        #endregion

        #region CUD
        public async Task RemoveNhacungcap(Nhacungcap nhacungcap)
        {
            _db.Nhacungcaps.Remove(nhacungcap);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateNhacungcap(Nhacungcap nhacungcap)
        {
            _db.Nhacungcaps.Update(nhacungcap);
            await _db.SaveChangesAsync();
        }
        public async Task CreateNhacungcap(Nhacungcap nhacungcap)
        {

            await _db.Nhacungcaps.AddAsync(nhacungcap);
            await _db.SaveChangesAsync();
        }
        #endregion
    }
}
