using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cuahangbanle.Migrations
{
    /// <inheritdoc />
    public partial class addProfileKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProfile",
                table: "UserProfile");

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "UserProfile",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProfile",
                table: "UserProfile",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_UserId",
                table: "UserProfile",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_AspNetUsers_UserId",
                table: "UserProfile",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_AspNetUsers_UserId",
                table: "UserProfile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProfile",
                table: "UserProfile");

            migrationBuilder.DropIndex(
                name: "IX_UserProfile_UserId",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "UserProfile");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProfile",
                table: "UserProfile",
                column: "UserId");
        }
    }
}
