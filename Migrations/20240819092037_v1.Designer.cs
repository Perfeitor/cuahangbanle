﻿// <auto-generated />
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
    [Migration("20240819092037_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("cuahangbanle.DBData.Models.DsQuyen", b =>
                {
                    b.Property<string>("Manhomquyen")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Maquyen")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Manhomquyen", "Maquyen");

                    b.HasIndex("Maquyen");

                    b.ToTable("DsQuyen");
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

                    b.ToTable("Quyen");
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
