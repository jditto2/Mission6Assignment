using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mission6Assignment.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Sci-Fi", "Christopher Nolan", false, null, "Mind-blowing!", "PG-13", "Inception", 2010 },
                    { 2, "Action", "Christopher Nolan", false, null, "Great Batman movie", "PG-13", "The Dark Knight", 2008 },
                    { 3, "Sci-Fi", "Christopher Nolan", false, null, "Epic space adventure", "PG-13", "Interstellar", 2014 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);
        }
    }
}
