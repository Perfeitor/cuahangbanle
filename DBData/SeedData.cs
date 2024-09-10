using cuahangbanle.DBData.Context;
using cuahangbanle.DBData.Models;
using System;
using System.Linq;

namespace cuahangbanle.DBData.Seed
{
    public static class SeedData
    {
        public static async Task Seed(DBContext dbContext)
        {
            if (!dbContext.Nhomquyens.Any())
            {
                dbContext.Nhomquyens.Add(new Nhomquyen { Manhomquyen = "Admin", Tennhomquyen = "Quản trị viên" });
            }
            await dbContext.SaveChangesAsync();

            if (!dbContext.Taikhoans.Any())
            {
                dbContext.Taikhoans.Add(new Taikhoan
                {
                    MaTK = "TK001",
                    TenTk = "admin",
                    Matkhau = "admin",
                    Manhomquyen = "Admin",
                });
            }
            await dbContext.SaveChangesAsync();

            if (!dbContext.Nhacungcaps.Any())
            {
                dbContext.Nhacungcaps.AddRange(
                    new Nhacungcap { MaNCC = "NCC001", TenNCC = "Nhà cung cấp 1" , Nguoitao = "TK001"},
                    new Nhacungcap { MaNCC = "NCC002", TenNCC = "Nhà cung cấp 2" , Nguoitao = "TK001"}
                );
            }
            await dbContext.SaveChangesAsync();

            if (!dbContext.Donvitinhs.Any())
            {
                dbContext.Donvitinhs.AddRange(
                    new Donvitinh { Madonvitinh = "lon", Donvile = "lon", Donvilon = "thùng" },
                    new Donvitinh { Madonvitinh = "goi", Donvile = "goi", Donvilon = "thùng" }
                );
            }
            await dbContext.SaveChangesAsync();

            if (!dbContext.Nganhhangs.Any())
            {
                dbContext.Nganhhangs.AddRange(
                    new Nganhhang { Manganhhang = "NH001", Tennganghang = "Ngành hàng 1", Ngaytao = DateTime.Now, Nguoitao = "Admin" },
                    new Nganhhang { Manganhhang = "NH002", Tennganghang = "Ngành hàng 2", Ngaytao = DateTime.Now, Nguoitao = "Admin" }
                );
            }
            await dbContext.SaveChangesAsync();

            if (!dbContext.Mathangs.Any())
            {
                try
                {
                    dbContext.Mathangs.AddRange(
                    new Mathang { Mamathang = "MH001", Tensanpham = "Coca", Manganhhang = "NH001", MaNCC = "NCC001", TenNCC = "Nhà cung cấp 1", Madonvitinh = "lon", Gianhap = 7000, Giaban = 8000, Phantramlai = 14.29M, Tienlai = 1000, Tonkho = 10 },
                    new Mathang { Mamathang = "MH002", Tensanpham = "Mì Hảo Hảo chua cay", Manganhhang = "NH002", MaNCC = "NCC002", TenNCC = "Nhà cung cấp 2", Madonvitinh = "goi", Gianhap = 3000, Giaban = 4000, Phantramlai = 33.33M, Tienlai = 1000, Tonkho = 20 }
                );
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            await dbContext.SaveChangesAsync();
        }
    }
}

