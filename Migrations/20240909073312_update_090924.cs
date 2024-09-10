using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuahangbanle.Migrations
{
    /// <inheritdoc />
    public partial class update_090924 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nguoitao",
                table: "Taikhoans");

            migrationBuilder.RenameColumn(
                name: "Nguoisua",
                table: "Taikhoans",
                newName: "Manguoitao");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Ngaytao",
                table: "Taikhoans",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Manguoisua",
                table: "Taikhoans",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manguoisua",
                table: "Taikhoans");

            migrationBuilder.RenameColumn(
                name: "Manguoitao",
                table: "Taikhoans",
                newName: "Nguoisua");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Ngaytao",
                table: "Taikhoans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nguoitao",
                table: "Taikhoans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
