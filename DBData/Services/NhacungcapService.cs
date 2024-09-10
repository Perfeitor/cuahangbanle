using cuahangbanle.DBData.Context;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.DBData.Services
{
    public class NhacungcapService : INhacungcapService
    {
        private readonly DBContext db;
        public NhacungcapService(DBContext _db)
        {
            db = _db;
        }
        #region Get data
        public async Task<List<Nhacungcap>> GetAllNhacungcap()
        {
            return await db.Nhacungcaps.ToListAsync();
        }
        #endregion
    }
}
