using cuahangbanle.DBData.Context;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.DBData.Services
{
    public class TaikhoanService : ITaikhoanService
    {
        private readonly DBContext db;

        public TaikhoanService(DBContext _db)
        {
            db = _db;
        }

        #region Getdata
        public async Task<List<Taikhoan>> GetAllTaikhoan()
        {
            return await db.Taikhoans.ToListAsync();
        }
        #endregion
    }
}
