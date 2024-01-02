using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chessinfo.Migrations
{
    /// <inheritdoc />
    public partial class titleid1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Title_TitleId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_TitleId",
                table: "Player");

            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Player",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
