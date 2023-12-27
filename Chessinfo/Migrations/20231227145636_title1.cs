using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chessinfo.Migrations
{
    /// <inheritdoc />
    public partial class title1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TitleCode",
                table: "Title",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<float>(
                name: "classicalRating",
                table: "Player",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<bool>(
                name: "IsMale",
                table: "Player",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "blitzRating",
                table: "Player",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "rapidRating",
                table: "Player",
                type: "real",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleCode",
                table: "Title");

            migrationBuilder.DropColumn(
                name: "IsMale",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "blitzRating",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "rapidRating",
                table: "Player");

            migrationBuilder.AlterColumn<float>(
                name: "classicalRating",
                table: "Player",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }
    }
}
