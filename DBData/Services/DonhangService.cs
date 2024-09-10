using cuahangbanle.DBData.Context;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.DBData.Services
{
    public class DonhangService : IDonhangService
    {
        private readonly DBContext db;
        public DonhangService(DBContext db)
        {
            this.db = db;
        }

        #region Get data
        public async Task<List<Donhang>> GetAllDonhang()
        {
            return await db.Donhangs.ToListAsync();
        }
        #endregion
    }
}
