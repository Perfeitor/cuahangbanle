using cuahangbanle.Data;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.Components.Services
{
    public class DonhangService : IDonhangService
    {
        private ApplicationDbContext _db;
        public DonhangService(ApplicationDbContext db)
        {
            _db = db;
        }

        #region Get data
        public async Task<List<Donhang>> GetAllDonhang()
        {
            return await _db.Donhangs.ToListAsync();
        }
        public async Task<Donhang> GetDonhangById(string id)
        {
            return await _db.Donhangs.FirstOrDefaultAsync(n => n.Madonhang == id) ?? new();
        }
        public async Task<List<DsMatHang>> GetDsMathangByDonhangId(string id)
        {
            return await _db.DsMatHangs.Where(n => n.Madonhang == id).ToListAsync();
        }
        public async Task<string> tienhang(string id)
        {
            var ListDonhang = await GetDsMathangByDonhangId(id);
            decimal tienhang = 0;
            foreach (var item in ListDonhang)
            {
                var mathang = await _db.Mathangs.FirstOrDefaultAsync(n => n.Mamathang == item.Mamathang);
                if (mathang != null)
                {
                    tienhang += mathang.Giaban * item.Soluong;
                }
            }
            return tienhang.ToString("F0");
        }
        #endregion

        #region CUD
        public async Task RemoveDonhang(Donhang donhang)
        {
            _db.Donhangs.Remove(donhang);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateDonhang(Donhang donhang)
        {
            _db.Donhangs.Update(donhang);
            await _db.SaveChangesAsync();
        }
        public async Task CreateDonhang(Donhang donhang)
        {

            await _db.Donhangs.AddAsync(donhang);
            await _db.SaveChangesAsync();
        }
        public async Task CreateDsMathang(DsMatHang ds)
        {
            await _db.DsMatHangs.AddAsync(ds);
            await _db.SaveChangesAsync();
        }
        #endregion
    }
}
