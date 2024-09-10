using cuahangbanle.DBData.Context;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.DBData.Services
{
    public class NganhhangService : INganhhangService
    {
        private readonly DBContext db;

        public NganhhangService(DBContext _db)
        {
            db = _db;
        }
        #region Getdata
        public async Task<List<Nganhhang>> GetAllNganhhang()
        {
            return await db.Nganhhangs.ToListAsync();
        }
        #endregion
    }
}
