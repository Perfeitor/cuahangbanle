﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cuahangbanle.DBData.Context;

#nullable disable

namespace cuahangbanle.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20240909081244_update_addpassword")]
    partial class update_addpassword
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("cuahangbanle.DBData.Models.Donhang", b =>
                {
                    b.Property<string>("Madonhang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Kieudonhang")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Ngaytao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nguoitao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Tienhang")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Tientralai")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Madonhang");

                    b.ToTable("Donhangs");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.Donvitinh", b =>
                {
                    b.Property<string>("Madonvitinh")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Donvile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Donvilon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Madonvitinh");

                    b.ToTable("Donvitinhs");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.DsMatHang", b =>
                {
                    b.Property<string>("Madonhang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Mamathang")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Madonhang", "Mamathang");

                    b.HasIndex("Mamathang");

                    b.ToTable("DsMatHangs");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.DsQuyen", b =>
                {
                    b.Property<string>("Manhomquyen")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Maquyen")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Manhomquyen", "Maquyen");

                    b.HasIndex("Maquyen");

                    b.ToTable("DsQuyens");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.Mathang", b =>
                {
                    b.Property<string>("Mamathang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Giaban")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Gianhap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MaNCC")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Madonvitinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Manganhhang")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Phantramlai")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TenNCC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tensanpham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Tienlai")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Tonkho")
                        .HasColumnType("int");

                    b.HasKey("Mamathang");

                    b.HasIndex("MaNCC");

                    b.HasIndex("Madonvitinh");

                    b.HasIndex("Manganhhang");

                    b.ToTable("Mathangs");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.Nganhhang", b =>
                {
                    b.Property<string>("Manganhhang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Ngaysua")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ngaytao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nguoisua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nguoitao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tennganghang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Manganhhang");

                    b.ToTable("Nganhhangs");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.Nhacungcap", b =>
                {
                    b.Property<string>("MaNCC")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Diachi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dienthoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Ngaysua")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ngaytao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nguoisua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nguoitao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNCC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNCC");

                    b.ToTable("Nhacungcaps");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.Nhomquyen", b =>
                {
                    b.Property<string>("Manhomquyen")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Tennhomquyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Manhomquyen");

                    b.ToTable("Nhomquyens");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.Quyen", b =>
                {
                    b.Property<string>("Maquyen")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenquyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Maquyen");

                    b.ToTable("Quyens");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.Taikhoan", b =>
                {
                    b.Property<string>("MaTK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Manguoisua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manguoitao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manhomquyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Matkhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Ngaysua")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Ngaytao")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenTk")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTK");

                    b.HasIndex("Manhomquyen");

                    b.ToTable("Taikhoans");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.DsMatHang", b =>
                {
                    b.HasOne("cuahangbanle.DBData.Models.Donhang", "Donhang")
                        .WithMany()
                        .HasForeignKey("Madonhang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cuahangbanle.DBData.Models.Mathang", "Mathang")
                        .WithMany()
                        .HasForeignKey("Mamathang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donhang");

                    b.Navigation("Mathang");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.DsQuyen", b =>
                {
                    b.HasOne("cuahangbanle.DBData.Models.Nhomquyen", "Nhomquyen")
                        .WithMany("DsQuyens")
                        .HasForeignKey("Manhomquyen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cuahangbanle.DBData.Models.Quyen", "Quyen")
                        .WithMany("DsQuyens")
                        .HasForeignKey("Maquyen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nhomquyen");

                    b.Navigation("Quyen");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.Mathang", b =>
                {
                    b.HasOne("cuahangbanle.DBData.Models.Nhacungcap", "Nhacungcap")
                        .WithMany()
                        .HasForeignKey("MaNCC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cuahangbanle.DBData.Models.Donvitinh", "Donvitinh")
                        .WithMany()
                        .HasForeignKey("Madonvitinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cuahangbanle.DBData.Models.Nganhhang", "Nganhhang")
                        .WithMany()
                        .HasForeignKey("Manganhhang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donvitinh");

                    b.Navigation("Nganhhang");

                    b.Navigation("Nhacungcap");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.Taikhoan", b =>
                {
                    b.HasOne("cuahangbanle.DBData.Models.Nhomquyen", "Nhomquyen")
                        .WithMany()
                        .HasForeignKey("Manhomquyen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nhomquyen");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.Nhomquyen", b =>
                {
                    b.Navigation("DsQuyens");
                });

            modelBuilder.Entity("cuahangbanle.DBData.Models.Quyen", b =>
                {
                    b.Navigation("DsQuyens");
                });
#pragma warning restore 612, 618
        }
    }
}
