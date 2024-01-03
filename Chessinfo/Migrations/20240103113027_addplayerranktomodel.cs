using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chessinfo.Migrations
{
    /// <inheritdoc />
    public partial class addplayerranktomodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "nationalRank",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "worldRank",
                table: "Player",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nationalRank",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "worldRank",
                table: "Player");
        }
    }
}
