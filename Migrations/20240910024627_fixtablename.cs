using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuahangbanle.Migrations
{
    /// <inheritdoc />
    public partial class fixtablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DsMatHangs_Donhangs_Madonhang",
                table: "DsMatHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_DsMatHangs_Mathangs_Mamathang",
                table: "DsMatHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_DsQuyens_Nhomquyens_Manhomquyen",
                table: "DsQuyens");

            migrationBuilder.DropForeignKey(
                name: "FK_DsQuyens_Quyens_Maquyen",
                table: "DsQuyens");

            migrationBuilder.DropForeignKey(
                name: "FK_Mathangs_Donvitinhs_Madonvitinh",
                table: "Mathangs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mathangs_Nganhhangs_Manganhhang",
                table: "Mathangs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mathangs_Nhacungcaps_MaNCC",
                table: "Mathangs");

            migrationBuilder.DropForeignKey(
                name: "FK_Taikhoans_Nhomquyens_Manhomquyen",
                table: "Taikhoans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Taikhoans",
                table: "Taikhoans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quyens",
                table: "Quyens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nhomquyens",
                table: "Nhomquyens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nhacungcaps",
                table: "Nhacungcaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nganhhangs",
                table: "Nganhhangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mathangs",
                table: "Mathangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DsQuyens",
                table: "DsQuyens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DsMatHangs",
                table: "DsMatHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Donvitinhs",
                table: "Donvitinhs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Donhangs",
                table: "Donhangs");

            migrationBuilder.RenameTable(
                name: "Taikhoans",
                newName: "Taikhoan");

            migrationBuilder.RenameTable(
                name: "Quyens",
                newName: "Quyen");

            migrationBuilder.RenameTable(
                name: "Nhomquyens",
                newName: "Nhomquyen");

            migrationBuilder.RenameTable(
                name: "Nhacungcaps",
                newName: "Nhacungcap");

            migrationBuilder.RenameTable(
                name: "Nganhhangs",
                newName: "Nganhhang");

            migrationBuilder.RenameTable(
                name: "Mathangs",
                newName: "Mathang");

            migrationBuilder.RenameTable(
                name: "DsQuyens",
                newName: "DsQuyen");

            migrationBuilder.RenameTable(
                name: "DsMatHangs",
                newName: "DsMatHang");

            migrationBuilder.RenameTable(
                name: "Donvitinhs",
                newName: "Donvitinh");

            migrationBuilder.RenameTable(
                name: "Donhangs",
                newName: "Donhang");

            migrationBuilder.RenameIndex(
                name: "IX_Taikhoans_Manhomquyen",
                table: "Taikhoan",
                newName: "IX_Taikhoan_Manhomquyen");

            migrationBuilder.RenameIndex(
                name: "IX_Mathangs_Manganhhang",
                table: "Mathang",
                newName: "IX_Mathang_Manganhhang");

            migrationBuilder.RenameIndex(
                name: "IX_Mathangs_MaNCC",
                table: "Mathang",
                newName: "IX_Mathang_MaNCC");

            migrationBuilder.RenameIndex(
                name: "IX_Mathangs_Madonvitinh",
                table: "Mathang",
                newName: "IX_Mathang_Madonvitinh");

            migrationBuilder.RenameIndex(
                name: "IX_DsQuyens_Maquyen",
                table: "DsQuyen",
                newName: "IX_DsQuyen_Maquyen");

            migrationBuilder.RenameIndex(
                name: "IX_DsMatHangs_Mamathang",
                table: "DsMatHang",
                newName: "IX_DsMatHang_Mamathang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Taikhoan",
                table: "Taikhoan",
                column: "MaTK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quyen",
                table: "Quyen",
                column: "Maquyen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nhomquyen",
                table: "Nhomquyen",
                column: "Manhomquyen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nhacungcap",
                table: "Nhacungcap",
                column: "MaNCC");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nganhhang",
                table: "Nganhhang",
                column: "Manganhhang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mathang",
                table: "Mathang",
                column: "Mamathang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DsQuyen",
                table: "DsQuyen",
                columns: new[] { "Manhomquyen", "Maquyen" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DsMatHang",
                table: "DsMatHang",
                columns: new[] { "Madonhang", "Mamathang" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Donvitinh",
                table: "Donvitinh",
                column: "Madonvitinh");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Donhang",
                table: "Donhang",
                column: "Madonhang");

            migrationBuilder.AddForeignKey(
                name: "FK_DsMatHang_Donhang_Madonhang",
                table: "DsMatHang",
                column: "Madonhang",
                principalTable: "Donhang",
                principalColumn: "Madonhang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DsMatHang_Mathang_Mamathang",
                table: "DsMatHang",
                column: "Mamathang",
                principalTable: "Mathang",
                principalColumn: "Mamathang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DsQuyen_Nhomquyen_Manhomquyen",
                table: "DsQuyen",
                column: "Manhomquyen",
                principalTable: "Nhomquyen",
                principalColumn: "Manhomquyen",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DsQuyen_Quyen_Maquyen",
                table: "DsQuyen",
                column: "Maquyen",
                principalTable: "Quyen",
                principalColumn: "Maquyen",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mathang_Donvitinh_Madonvitinh",
                table: "Mathang",
                column: "Madonvitinh",
                principalTable: "Donvitinh",
                principalColumn: "Madonvitinh",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mathang_Nganhhang_Manganhhang",
                table: "Mathang",
                column: "Manganhhang",
                principalTable: "Nganhhang",
                principalColumn: "Manganhhang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mathang_Nhacungcap_MaNCC",
                table: "Mathang",
                column: "MaNCC",
                principalTable: "Nhacungcap",
                principalColumn: "MaNCC",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taikhoan_Nhomquyen_Manhomquyen",
                table: "Taikhoan",
                column: "Manhomquyen",
                principalTable: "Nhomquyen",
                principalColumn: "Manhomquyen",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DsMatHang_Donhang_Madonhang",
                table: "DsMatHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DsMatHang_Mathang_Mamathang",
                table: "DsMatHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DsQuyen_Nhomquyen_Manhomquyen",
                table: "DsQuyen");

            migrationBuilder.DropForeignKey(
                name: "FK_DsQuyen_Quyen_Maquyen",
                table: "DsQuyen");

            migrationBuilder.DropForeignKey(
                name: "FK_Mathang_Donvitinh_Madonvitinh",
                table: "Mathang");

            migrationBuilder.DropForeignKey(
                name: "FK_Mathang_Nganhhang_Manganhhang",
                table: "Mathang");

            migrationBuilder.DropForeignKey(
                name: "FK_Mathang_Nhacungcap_MaNCC",
                table: "Mathang");

            migrationBuilder.DropForeignKey(
                name: "FK_Taikhoan_Nhomquyen_Manhomquyen",
                table: "Taikhoan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Taikhoan",
                table: "Taikhoan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quyen",
                table: "Quyen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nhomquyen",
                table: "Nhomquyen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nhacungcap",
                table: "Nhacungcap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nganhhang",
                table: "Nganhhang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mathang",
                table: "Mathang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DsQuyen",
                table: "DsQuyen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DsMatHang",
                table: "DsMatHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Donvitinh",
                table: "Donvitinh");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Donhang",
                table: "Donhang");

            migrationBuilder.RenameTable(
                name: "Taikhoan",
                newName: "Taikhoans");

            migrationBuilder.RenameTable(
                name: "Quyen",
                newName: "Quyens");

            migrationBuilder.RenameTable(
                name: "Nhomquyen",
                newName: "Nhomquyens");

            migrationBuilder.RenameTable(
                name: "Nhacungcap",
                newName: "Nhacungcaps");

            migrationBuilder.RenameTable(
                name: "Nganhhang",
                newName: "Nganhhangs");

            migrationBuilder.RenameTable(
                name: "Mathang",
                newName: "Mathangs");

            migrationBuilder.RenameTable(
                name: "DsQuyen",
                newName: "DsQuyens");

            migrationBuilder.RenameTable(
                name: "DsMatHang",
                newName: "DsMatHangs");

            migrationBuilder.RenameTable(
                name: "Donvitinh",
                newName: "Donvitinhs");

            migrationBuilder.RenameTable(
                name: "Donhang",
                newName: "Donhangs");

            migrationBuilder.RenameIndex(
                name: "IX_Taikhoan_Manhomquyen",
                table: "Taikhoans",
                newName: "IX_Taikhoans_Manhomquyen");

            migrationBuilder.RenameIndex(
                name: "IX_Mathang_Manganhhang",
                table: "Mathangs",
                newName: "IX_Mathangs_Manganhhang");

            migrationBuilder.RenameIndex(
                name: "IX_Mathang_MaNCC",
                table: "Mathangs",
                newName: "IX_Mathangs_MaNCC");

            migrationBuilder.RenameIndex(
                name: "IX_Mathang_Madonvitinh",
                table: "Mathangs",
                newName: "IX_Mathangs_Madonvitinh");

            migrationBuilder.RenameIndex(
                name: "IX_DsQuyen_Maquyen",
                table: "DsQuyens",
                newName: "IX_DsQuyens_Maquyen");

            migrationBuilder.RenameIndex(
                name: "IX_DsMatHang_Mamathang",
                table: "DsMatHangs",
                newName: "IX_DsMatHangs_Mamathang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Taikhoans",
                table: "Taikhoans",
                column: "MaTK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quyens",
                table: "Quyens",
                column: "Maquyen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nhomquyens",
                table: "Nhomquyens",
                column: "Manhomquyen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nhacungcaps",
                table: "Nhacungcaps",
                column: "MaNCC");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nganhhangs",
                table: "Nganhhangs",
                column: "Manganhhang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mathangs",
                table: "Mathangs",
                column: "Mamathang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DsQuyens",
                table: "DsQuyens",
                columns: new[] { "Manhomquyen", "Maquyen" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DsMatHangs",
                table: "DsMatHangs",
                columns: new[] { "Madonhang", "Mamathang" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Donvitinhs",
                table: "Donvitinhs",
                column: "Madonvitinh");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Donhangs",
                table: "Donhangs",
                column: "Madonhang");

            migrationBuilder.AddForeignKey(
                name: "FK_DsMatHangs_Donhangs_Madonhang",
                table: "DsMatHangs",
                column: "Madonhang",
                principalTable: "Donhangs",
                principalColumn: "Madonhang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DsMatHangs_Mathangs_Mamathang",
                table: "DsMatHangs",
                column: "Mamathang",
                principalTable: "Mathangs",
                principalColumn: "Mamathang",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Mathangs_Donvitinhs_Madonvitinh",
                table: "Mathangs",
                column: "Madonvitinh",
                principalTable: "Donvitinhs",
                principalColumn: "Madonvitinh",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mathangs_Nganhhangs_Manganhhang",
                table: "Mathangs",
                column: "Manganhhang",
                principalTable: "Nganhhangs",
                principalColumn: "Manganhhang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mathangs_Nhacungcaps_MaNCC",
                table: "Mathangs",
                column: "MaNCC",
                principalTable: "Nhacungcaps",
                principalColumn: "MaNCC",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taikhoans_Nhomquyens_Manhomquyen",
                table: "Taikhoans",
                column: "Manhomquyen",
                principalTable: "Nhomquyens",
                principalColumn: "Manhomquyen",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
