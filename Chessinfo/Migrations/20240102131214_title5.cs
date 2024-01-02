using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chessinfo.Migrations
{
    /// <inheritdoc />
    public partial class title5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Player_TitleId",
                table: "Player",
                column: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Title_TitleId",
                table: "Player",
                column: "TitleId",
                principalTable: "Title",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Title_TitleId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_TitleId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "Player");
        }
    }
}
