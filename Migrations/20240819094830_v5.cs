using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuahangbanle.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donhangs",
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
                    table.PrimaryKey("PK_Donhangs", x => x.Madonhang);
                });

            migrationBuilder.CreateTable(
                name: "Mathangs",
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
                    table.PrimaryKey("PK_Mathangs", x => x.Mamathang);
                    table.ForeignKey(
                        name: "FK_Mathangs_Donvitinhs_Madonvitinh",
                        column: x => x.Madonvitinh,
                        principalTable: "Donvitinhs",
                        principalColumn: "Madonvitinh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mathangs_Nganhhangs_Manganhhang",
                        column: x => x.Manganhhang,
                        principalTable: "Nganhhangs",
                        principalColumn: "Manganhhang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mathangs_Nhacungcaps_MaNCC",
                        column: x => x.MaNCC,
                        principalTable: "Nhacungcaps",
                        principalColumn: "MaNCC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DsMatHangs",
                columns: table => new
                {
                    Madonhang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mamathang = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DsMatHangs", x => new { x.Madonhang, x.Mamathang });
                    table.ForeignKey(
                        name: "FK_DsMatHangs_Donhangs_Madonhang",
                        column: x => x.Madonhang,
                        principalTable: "Donhangs",
                        principalColumn: "Madonhang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DsMatHangs_Mathangs_Mamathang",
                        column: x => x.Mamathang,
                        principalTable: "Mathangs",
                        principalColumn: "Mamathang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DsMatHangs_Mamathang",
                table: "DsMatHangs",
                column: "Mamathang");

            migrationBuilder.CreateIndex(
                name: "IX_Mathangs_Madonvitinh",
                table: "Mathangs",
                column: "Madonvitinh");

            migrationBuilder.CreateIndex(
                name: "IX_Mathangs_MaNCC",
                table: "Mathangs",
                column: "MaNCC");

            migrationBuilder.CreateIndex(
                name: "IX_Mathangs_Manganhhang",
                table: "Mathangs",
                column: "Manganhhang");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DsMatHangs");

            migrationBuilder.DropTable(
                name: "Donhangs");

            migrationBuilder.DropTable(
                name: "Mathangs");
        }
    }
}
