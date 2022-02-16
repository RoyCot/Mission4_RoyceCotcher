using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4_RoyceCotcher.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    MovieId = table.Column<uint>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1u, "Adventure", "Ben Stiller", false, "", "", "PG", "Secret Life of Walter Mitty, The", (ushort)2013 });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2u, "Animated", "Ron Clements, John Musker", false, "", "", "G", "Princess and the Frog, The", (ushort)2009 });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3u, "War Drama", "Phil Alden Robinson, Richard Loncraine, Mikael Salomon, David Nutter, Tom Hanks, David Leland, David Frankel, Tony To", false, "", "", "TV-MA", "Band of Brothers", (ushort)2001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
