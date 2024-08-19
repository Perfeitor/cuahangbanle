using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuahangbanle.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DsQuyen_Nhomquyens_Manhomquyen",
                table: "DsQuyen");

            migrationBuilder.DropForeignKey(
                name: "FK_DsQuyen_Quyen_Maquyen",
                table: "DsQuyen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quyen",
                table: "Quyen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DsQuyen",
                table: "DsQuyen");

            migrationBuilder.RenameTable(
                name: "Quyen",
                newName: "Quyens");

            migrationBuilder.RenameTable(
                name: "DsQuyen",
                newName: "DsQuyens");

            migrationBuilder.RenameIndex(
                name: "IX_DsQuyen_Maquyen",
                table: "DsQuyens",
                newName: "IX_DsQuyens_Maquyen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quyens",
                table: "Quyens",
                column: "Maquyen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DsQuyens",
                table: "DsQuyens",
                columns: new[] { "Manhomquyen", "Maquyen" });

            migrationBuilder.CreateTable(
                name: "Taikhoans",
                columns: table => new
                {
                    MaTK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manhomquyen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nguoitao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nguoisua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngaysua = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taikhoans", x => x.MaTK);
                    table.ForeignKey(
                        name: "FK_Taikhoans_Nhomquyens_Manhomquyen",
                        column: x => x.Manhomquyen,
                        principalTable: "Nhomquyens",
                        principalColumn: "Manhomquyen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Taikhoans_Manhomquyen",
                table: "Taikhoans",
                column: "Manhomquyen");

            migrationBuilder.AddForeignKey(
                name: "FK_DsQuyens_Nhomquyens_Manhomquyen",
                table: "DsQuyens",
                column: "Manhomquyen",
                principalTable: "Nhomquyens",
                principalColumn: "Manhomquyen",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DsQuyens_Quyens_Maquyen",
                table: "DsQuyens",
                column: "Maquyen",
                principalTable: "Quyens",
                principalColumn: "Maquyen",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DsQuyens_Nhomquyens_Manhomquyen",
                table: "DsQuyens");

            migrationBuilder.DropForeignKey(
                name: "FK_DsQuyens_Quyens_Maquyen",
                table: "DsQuyens");

            migrationBuilder.DropTable(
                name: "Taikhoans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quyens",
                table: "Quyens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DsQuyens",
                table: "DsQuyens");

            migrationBuilder.RenameTable(
                name: "Quyens",
                newName: "Quyen");

            migrationBuilder.RenameTable(
                name: "DsQuyens",
                newName: "DsQuyen");

            migrationBuilder.RenameIndex(
                name: "IX_DsQuyens_Maquyen",
                table: "DsQuyen",
                newName: "IX_DsQuyen_Maquyen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quyen",
                table: "Quyen",
                column: "Maquyen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DsQuyen",
                table: "DsQuyen",
                columns: new[] { "Manhomquyen", "Maquyen" });

            migrationBuilder.AddForeignKey(
                name: "FK_DsQuyen_Nhomquyens_Manhomquyen",
                table: "DsQuyen",
                column: "Manhomquyen",
                principalTable: "Nhomquyens",
                principalColumn: "Manhomquyen",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DsQuyen_Quyen_Maquyen",
                table: "DsQuyen",
                column: "Maquyen",
                principalTable: "Quyen",
                principalColumn: "Maquyen",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
