using cuahangbanle.Data;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.Components.Services
{
    public class MathangService : IMathangService
    {
        private ApplicationDbContext _db;
        public MathangService(ApplicationDbContext db)
        {
            _db = db;
        }

        #region Get data
        public async Task<List<Mathang>> GetAllMathang()
        {
            return await _db.Mathangs.ToListAsync();
        }
        public async Task<Mathang> GetMathangById(string id)
        {
            return await _db.Mathangs.FirstOrDefaultAsync(n => n.Mamathang == id) ?? new();
        }
        #endregion

        #region CUD
        public async Task RemoveMathang(Mathang mathang)
        {
            _db.Mathangs.Remove(mathang);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateMathang(Mathang mathang)
        {
            _db.Mathangs.Update(mathang);
            await _db.SaveChangesAsync();
        }
        public async Task CreateMathang(Mathang mathang)
        {

            await _db.Mathangs.AddAsync(mathang);
            await _db.SaveChangesAsync();
        }
        #endregion
    }
}
