using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chessinfo.Migrations
{
    /// <inheritdoc />
    public partial class country2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Country_countryId",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "countryId",
                table: "Player",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Player_countryId",
                table: "Player",
                newName: "IX_Player_CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Country_CountryId",
                table: "Player",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Country_CountryId",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Player",
                newName: "countryId");

            migrationBuilder.RenameIndex(
                name: "IX_Player_CountryId",
                table: "Player",
                newName: "IX_Player_countryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Country_countryId",
                table: "Player",
                column: "countryId",
                principalTable: "Country",
                principalColumn: "Id");
        }
    }
}
