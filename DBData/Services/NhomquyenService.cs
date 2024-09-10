using cuahangbanle.DBData.Context;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.DBData.Services
{
    public class NhomquyenService : INhomquyenServicecs
    {
        private readonly DBContext db;
        public NhomquyenService(DBContext db)
        {
            this.db = db;
        }

        #region Get data
        public async Task<List<Nhomquyen>> GetAllNhomquyen()
        {
            var t = await db.Nhomquyens.ToListAsync();
            return t;
        }
        #endregion
    }
}
