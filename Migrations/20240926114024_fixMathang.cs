using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuahangbanle.Migrations
{
    /// <inheritdoc />
    public partial class fixMathang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Manhomhang",
                table: "Mathang",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Mathang_Manhomhang",
                table: "Mathang",
                column: "Manhomhang");

            migrationBuilder.AddForeignKey(
                name: "FK_Mathang_Nhomhang_Manhomhang",
                table: "Mathang",
                column: "Manhomhang",
                principalTable: "Nhomhang",
                principalColumn: "Manhomhang",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mathang_Nhomhang_Manhomhang",
                table: "Mathang");

            migrationBuilder.DropIndex(
                name: "IX_Mathang_Manhomhang",
                table: "Mathang");

            migrationBuilder.DropColumn(
                name: "Manhomhang",
                table: "Mathang");
        }
    }
}
