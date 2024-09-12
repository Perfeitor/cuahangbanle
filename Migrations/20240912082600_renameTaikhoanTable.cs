using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuahangbanle.Migrations
{
    /// <inheritdoc />
    public partial class renameTaikhoanTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Taikhoan");

            migrationBuilder.CreateTable(
                name: "UserProfile",
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
                    table.PrimaryKey("PK_UserProfile", x => x.UserId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.CreateTable(
                name: "Taikhoan",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Hoten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manguoisua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manguoitao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngaysua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taikhoan", x => x.UserId);
                });
        }
    }
}
