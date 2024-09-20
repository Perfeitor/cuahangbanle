using cuahangbanle.Data;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace cuahangbanle.Components.Services
{
    public class NganhhangService : INganhhangService
    {
        private ApplicationDbContext _db;
        public NganhhangService(ApplicationDbContext db)
        {
            _db = db;
        }

        #region Get data
        public async Task<List<Nganhhang>> GetAllNganhhang()
        {
            return await _db.Nganhhangs.ToListAsync();
        }
        public async Task<Nganhhang> GetNganhhangById(string id)
        {
            return await _db.Nganhhangs.FirstOrDefaultAsync(n => n.Manganhhang == id) ?? new();
        }
        #endregion

        #region CUD
        public async Task RemoveNganhhang(Nganhhang nganh)
        {
            _db.Nganhhangs.Remove(nganh);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateNganhhang(Nganhhang nganh)
        {
            _db.Nganhhangs.Update(nganh);
            await _db.SaveChangesAsync();
        }
        public async Task CreateNganhhang(Nganhhang nganh)
        {

            await _db.Nganhhangs.AddAsync(nganh);
            await _db.SaveChangesAsync();
        }
        #endregion
    }
}
