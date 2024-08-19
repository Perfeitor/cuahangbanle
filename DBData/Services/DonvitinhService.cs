using cuahangbanle.DBData.Context;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.DBData.Services
{
    public class DonvitinhService : IDonvitinhService
    {
        private DBContext db;
        public DonvitinhService(DBContext _db)
        {
            db = _db;
        }

        #region Get data
        public async Task<List<Donvitinh>> GetAllDonvitinh()
        {
            //return await db.Donvitinhs.ToListAsync();
            return new List<Donvitinh>();
        }
        #endregion
    }
}
