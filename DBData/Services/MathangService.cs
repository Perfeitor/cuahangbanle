using cuahangbanle.DBData.Context;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.DBData.Services
{
    public class MathangService : IMathangService
    {
        public DBContext db;
        public MathangService(DBContext _db) {
            db = _db; 
        }

        #region
        public async Task<List<Mathang>> GetAllMathang()
        {
            //return await db.Mathangs.ToListAsync();
            return new List<Mathang>();
        }
        #endregion
    }
}
