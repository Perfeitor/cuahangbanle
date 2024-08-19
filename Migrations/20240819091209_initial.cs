using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuahangbanle.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nhomquyens",
                columns: table => new
                {
                    Manhomquyen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tennhomquyen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhomquyens", x => x.Manhomquyen);
                });

            migrationBuilder.CreateTable(
                name: "Quyen",
                columns: table => new
                {
                    Maquyen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tenquyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quyen", x => x.Maquyen);
                });

            migrationBuilder.CreateTable(
                name: "DsQuyen",
                columns: table => new
                {
                    Manhomquyen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Maquyen = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DsQuyen", x => new { x.Manhomquyen, x.Maquyen });
                    table.ForeignKey(
                        name: "FK_DsQuyen_Nhomquyens_Manhomquyen",
                        column: x => x.Manhomquyen,
                        principalTable: "Nhomquyens",
                        principalColumn: "Manhomquyen",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DsQuyen_Quyen_Maquyen",
                        column: x => x.Maquyen,
                        principalTable: "Quyen",
                        principalColumn: "Maquyen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DsQuyen_Maquyen",
                table: "DsQuyen",
                column: "Maquyen");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DsQuyen");

            migrationBuilder.DropTable(
                name: "Nhomquyens");

            migrationBuilder.DropTable(
                name: "Quyen");
        }
    }
}
