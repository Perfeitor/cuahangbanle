using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuahangbanle.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Nganhhang",
                table: "Nganhhang");

            migrationBuilder.RenameTable(
                name: "Nganhhang",
                newName: "Nganhhangs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nganhhangs",
                table: "Nganhhangs",
                column: "Manganhhang");

            migrationBuilder.CreateTable(
                name: "Donvitinhs",
                columns: table => new
                {
                    Madonvitinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Donvile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Donvilon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donvitinhs", x => x.Madonvitinh);
                });

            migrationBuilder.CreateTable(
                name: "Nhacungcaps",
                columns: table => new
                {
                    MaNCC = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dienthoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nguoitao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nguoisua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngaysua = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhacungcaps", x => x.MaNCC);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donvitinhs");

            migrationBuilder.DropTable(
                name: "Nhacungcaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nganhhangs",
                table: "Nganhhangs");

            migrationBuilder.RenameTable(
                name: "Nganhhangs",
                newName: "Nganhhang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nganhhang",
                table: "Nganhhang",
                column: "Manganhhang");
        }
    }
}
