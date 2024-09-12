using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuahangbanle.Migrations
{
    /// <inheritdoc />
    public partial class updatev2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donhang",
                columns: table => new
                {
                    Madonhang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nguoitao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kieudonhang = table.Column<bool>(type: "bit", nullable: false),
                    Tienhang = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tientralai = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donhang", x => x.Madonhang);
                });

            migrationBuilder.CreateTable(
                name: "Donvitinh",
                columns: table => new
                {
                    Madonvitinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Donvile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Donvilon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donvitinh", x => x.Madonvitinh);
                });

            migrationBuilder.CreateTable(
                name: "Nganhhang",
                columns: table => new
                {
                    Manganhhang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tennganghang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nguoitao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaysua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nguoisua = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nganhhang", x => x.Manganhhang);
                });

            migrationBuilder.CreateTable(
                name: "Nhacungcap",
                columns: table => new
                {
                    MaNCC = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dienthoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nguoitao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nguoisua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngaysua = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhacungcap", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "Taikhoan",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Hoten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manguoitao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Manguoisua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngaysua = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taikhoan", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Mathang",
                columns: table => new
                {
                    Mamathang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Manganhhang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaNCC = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tensanpham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Madonvitinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tonkho = table.Column<int>(type: "int", nullable: false),
                    Gianhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Giaban = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Phantramlai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tienlai = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mathang", x => x.Mamathang);
                    table.ForeignKey(
                        name: "FK_Mathang_Donvitinh_Madonvitinh",
                        column: x => x.Madonvitinh,
                        principalTable: "Donvitinh",
                        principalColumn: "Madonvitinh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mathang_Nganhhang_Manganhhang",
                        column: x => x.Manganhhang,
                        principalTable: "Nganhhang",
                        principalColumn: "Manganhhang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mathang_Nhacungcap_MaNCC",
                        column: x => x.MaNCC,
                        principalTable: "Nhacungcap",
                        principalColumn: "MaNCC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DsMatHang",
                columns: table => new
                {
                    Madonhang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mamathang = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DsMatHang", x => new { x.Madonhang, x.Mamathang });
                    table.ForeignKey(
                        name: "FK_DsMatHang_Donhang_Madonhang",
                        column: x => x.Madonhang,
                        principalTable: "Donhang",
                        principalColumn: "Madonhang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DsMatHang_Mathang_Mamathang",
                        column: x => x.Mamathang,
                        principalTable: "Mathang",
                        principalColumn: "Mamathang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DsMatHang_Mamathang",
                table: "DsMatHang",
                column: "Mamathang");

            migrationBuilder.CreateIndex(
                name: "IX_Mathang_Madonvitinh",
                table: "Mathang",
                column: "Madonvitinh");

            migrationBuilder.CreateIndex(
                name: "IX_Mathang_MaNCC",
                table: "Mathang",
                column: "MaNCC");

            migrationBuilder.CreateIndex(
                name: "IX_Mathang_Manganhhang",
                table: "Mathang",
                column: "Manganhhang");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DsMatHang");

            migrationBuilder.DropTable(
                name: "Taikhoan");

            migrationBuilder.DropTable(
                name: "Donhang");

            migrationBuilder.DropTable(
                name: "Mathang");

            migrationBuilder.DropTable(
                name: "Donvitinh");

            migrationBuilder.DropTable(
                name: "Nganhhang");

            migrationBuilder.DropTable(
                name: "Nhacungcap");
        }
    }
}
