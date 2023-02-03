using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6Assignment.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Drama", "Gabriele Muccino", false, null, null, "PG-13", "The Pursuit of Happyness", 2006 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Sci-fi", "Jon Watts", false, null, null, "PG-13", "Spider-Man: No Way Home", 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "responses",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "responses",
                keyColumn: "MovieId",
                keyValue: 3);
        }
    }
}
