using cuahangbanle.DBData.Context;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.DBData.Services
{
    public class MathangService : IMathangService
    {
        private readonly DBContext db;
        public MathangService(DBContext _db) {
            db = _db; 
        }

        #region
        public async Task<List<Mathang>> GetAllMathang()
        {
            return await db.Mathangs.ToListAsync();
        }
        public async Task AddMathang(Mathang mathang)
        {
            await db.Mathangs.AddAsync(mathang);
            await db.SaveChangesAsync();
        }
        public async Task EditMathang(Mathang mathang)
        {
            db.Mathangs.Update(mathang);
            await db.SaveChangesAsync();
        }
        public async Task DeleteMathang(Mathang mathang)
        {
            db.Mathangs.Remove(mathang);
            await db.SaveChangesAsync();
        }
        #endregion
    }
}
