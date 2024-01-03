using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chessinfo.Migrations
{
    /// <inheritdoc />
    public partial class tournamenttoGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TournamentId",
                table: "Game",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Game_TournamentId",
                table: "Game",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Tournament_TournamentId",
                table: "Game",
                column: "TournamentId",
                principalTable: "Tournament",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Tournament_TournamentId",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_TournamentId",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "TournamentId",
                table: "Game");
        }
    }
}
