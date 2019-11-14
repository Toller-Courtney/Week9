using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class ImdbIDNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imdb_ID",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "ImdbID",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImdbID",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "Imdb_ID",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
