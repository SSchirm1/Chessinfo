using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chessinfo.Migrations
{
    /// <inheritdoc />
    public partial class country1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "countryId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Player_countryId",
                table: "Player",
                column: "countryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Country_countryId",
                table: "Player",
                column: "countryId",
                principalTable: "Country",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Country_countryId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_countryId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "countryId",
                table: "Player");
        }
    }
}
