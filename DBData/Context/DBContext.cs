using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.DBData.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        #region DbSet
        public DbSet<Nhomquyen> Nhomquyens { get; set; }
        public DbSet<Quyen> Quyens { get; set; }
        public DbSet<DsQuyen> DsQuyens { get; set; }
        public DbSet<Taikhoan> Taikhoans { get; set; }
        public DbSet<Nganhhang> Nganhhangs { get; set; }
        public DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public DbSet<Donvitinh> Donvitinhs { get; set; }
        public DbSet<Mathang> Mathangs { get; set; }
        public DbSet<Donhang> Donhangs { get; set; }
        public DbSet<DsMatHang> DsMatHangs { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Nhomquyen
            modelBuilder.Entity<Nhomquyen>()
                .HasKey(n => n.Manhomquyen);

            modelBuilder.Entity<Nhomquyen>()
                .Property(n => n.Manhomquyen)
                .IsRequired();

            modelBuilder.Entity<Nhomquyen>()
                .Property(n => n.Tennhomquyen)
                .IsRequired();
            #endregion

            #region Quyen
            modelBuilder.Entity<Quyen>()
                .HasKey(q => q.Maquyen);

            modelBuilder.Entity<Quyen>()
                .Property(q => q.Maquyen)
                .IsRequired();

            modelBuilder.Entity<Quyen>()
                .Property(q => q.Tenquyen)
                .IsRequired();
            #endregion

            #region DsQuyen
            modelBuilder.Entity<DsQuyen>()
                .HasKey(d => new { d.Manhomquyen, d.Maquyen });

            modelBuilder.Entity<DsQuyen>()
                .HasOne(d => d.Nhomquyen)
                .WithMany(n => n.DsQuyens)
                .HasForeignKey(d => d.Manhomquyen)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DsQuyen>()
                .HasOne(d => d.Quyen)
                .WithMany(q => q.DsQuyens)
                .HasForeignKey(d => d.Maquyen)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Taikhoan
            modelBuilder.Entity<Taikhoan>()
                .HasKey(t => t.MaTK);

            modelBuilder.Entity<Taikhoan>()
                .HasOne(t => t.Nhomquyen)
                .WithMany()
                .HasForeignKey(n => n.Manhomquyen)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Nganhhang
            modelBuilder.Entity<Nganhhang>()
                .HasKey(n => n.Manganhhang);
            #endregion

            #region Nhacungcap
            modelBuilder.Entity<Nhacungcap>()
                .HasKey(n => n.MaNCC);
            #endregion

            #region Donvitinh
            modelBuilder.Entity<Donvitinh>()
                .HasKey(d => d.Madonvitinh);
            #endregion

            #region Mathang
            modelBuilder.Entity<Mathang>()
                .HasKey(m => m.Mamathang);

            modelBuilder.Entity<Mathang>()
                .HasOne(m => m.Nganhhang)
                .WithMany()
                .HasForeignKey(m => m.Manganhhang)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Mathang>()
                .HasOne(m => m.Nhacungcap)
                .WithMany()
                .HasForeignKey(m => m.MaNCC)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Mathang>()
                .HasOne(m => m.Donvitinh)
                .WithMany()
                .HasForeignKey(m => m.Madonvitinh)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Donhang
            modelBuilder.Entity<Donhang>()
                .HasKey(d => d.Madonhang);
            #endregion

            #region DsMatHang
            modelBuilder.Entity<DsMatHang>()
                .HasKey(d => new { d.Madonhang, d.Mamathang });

            modelBuilder.Entity<DsMatHang>()
                .HasOne(d => d.Donhang)
                .WithMany()
                .HasForeignKey(d => d.Madonhang)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DsMatHang>()
                .HasOne(d => d.Mathang)
                .WithMany()
                .HasForeignKey(d => d.Mamathang)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
