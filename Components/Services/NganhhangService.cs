using cuahangbanle.Data;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

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
        #endregion
    }
}
