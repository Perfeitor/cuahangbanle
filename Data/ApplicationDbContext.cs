using cuahangbanle.DBData.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    #region DbSet
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Nganhhang> Nganhhangs { get; set; }
    public DbSet<Nhacungcap> Nhacungcaps { get; set; }
    public DbSet<Donvitinh> Donvitinhs { get; set; }
    public DbSet<Mathang> Mathangs { get; set; }
    public DbSet<Donhang> Donhangs { get; set; }
    public DbSet<DsMatHang> DsMatHangs { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        #region User
        modelBuilder.Entity<UserProfile>()
            .HasKey(t => t.ProfileId);

        modelBuilder.Entity<UserProfile>()
            .HasOne(t => t.User)
            .WithOne()
            .HasForeignKey<UserProfile>(t => t.UserId)
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
