using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuahangbanle.Migrations
{
    /// <inheritdoc />
    public partial class add_create_update_history_for_some_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Ngaysua",
                table: "Mathang",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngaytao",
                table: "Mathang",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Nguoisua",
                table: "Mathang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nguoitao",
                table: "Mathang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngaysua",
                table: "Donvitinh",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngaytao",
                table: "Donvitinh",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Nguoisua",
                table: "Donvitinh",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nguoitao",
                table: "Donvitinh",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nguoitao",
                table: "Donhang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Ngaytao",
                table: "Donhang",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngaysua",
                table: "Donhang",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nguoisua",
                table: "Donhang",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ngaysua",
                table: "Mathang");

            migrationBuilder.DropColumn(
                name: "Ngaytao",
                table: "Mathang");

            migrationBuilder.DropColumn(
                name: "Nguoisua",
                table: "Mathang");

            migrationBuilder.DropColumn(
                name: "Nguoitao",
                table: "Mathang");

            migrationBuilder.DropColumn(
                name: "Ngaysua",
                table: "Donvitinh");

            migrationBuilder.DropColumn(
                name: "Ngaytao",
                table: "Donvitinh");

            migrationBuilder.DropColumn(
                name: "Nguoisua",
                table: "Donvitinh");

            migrationBuilder.DropColumn(
                name: "Nguoitao",
                table: "Donvitinh");

            migrationBuilder.DropColumn(
                name: "Ngaysua",
                table: "Donhang");

            migrationBuilder.DropColumn(
                name: "Nguoisua",
                table: "Donhang");

            migrationBuilder.AlterColumn<string>(
                name: "Nguoitao",
                table: "Donhang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Ngaytao",
                table: "Donhang",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
