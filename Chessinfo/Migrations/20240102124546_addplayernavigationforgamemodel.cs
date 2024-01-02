using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chessinfo.Migrations
{
    /// <inheritdoc />
    public partial class addplayernavigationforgamemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "Game",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

          

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "Game",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
