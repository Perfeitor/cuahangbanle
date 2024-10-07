using cuahangbanle.Data.Models;
using cuahangbanle.Data;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.Components.Services
{
    public class DonvitinhService : IDonvitinhService
    {
        private ApplicationDbContext _db;
        public DonvitinhService(ApplicationDbContext db)
        {
            _db = db;
        }

        #region Get data
        public async Task<List<Donvitinh>> GetAllDonvitinh()
        {
            return await _db.Donvitinhs.ToListAsync();
        }
        public async Task<Donvitinh> GetDonvitinhById(string id)
        {
            return await _db.Donvitinhs.FirstOrDefaultAsync(n => n.Madonvitinh == id) ?? new();
        }
        #endregion

        #region CUD
        public async Task RemoveDonvitinh(Donvitinh donvi)
        {
            _db.Donvitinhs.Remove(donvi);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateDonvitinh(Donvitinh donvi)
        {
            _db.Donvitinhs.Update(donvi);
            await _db.SaveChangesAsync();
        }
        public async Task CreateDonvitinh(Donvitinh donvi)
        {

            await _db.Donvitinhs.AddAsync(donvi);
            await _db.SaveChangesAsync();
        }
        
        #endregion
    }
}
