using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuahangbanle.Migrations
{
    /// <inheritdoc />
    public partial class addNhomhang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nhomhang",
                columns: table => new
                {
                    Manhomhang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tennhomhang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nguoitao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaysua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nguoisua = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhomhang", x => x.Manhomhang);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nhomhang");
        }
    }
}
