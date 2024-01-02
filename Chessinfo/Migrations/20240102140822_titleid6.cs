using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chessinfo.Migrations
{
    /// <inheritdoc />
    public partial class titleid6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Player_BlackId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_Game_Player_WhiteId",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_BlackId",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_WhiteId",
                table: "Game");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Game_BlackId",
                table: "Game",
                column: "BlackId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_WhiteId",
                table: "Game",
                column: "WhiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Player_BlackId",
                table: "Game",
                column: "BlackId",
                principalTable: "Player",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Player_WhiteId",
                table: "Game",
                column: "WhiteId",
                principalTable: "Player",
                principalColumn: "Id");
        }
    }
}
