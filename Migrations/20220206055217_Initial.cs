using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4Movies.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieInputs",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<string>(nullable: true),
                    Lent_To = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieInputs", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "MovieInputs",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Joss Wheadon", null, "", "Slam dunk movie.", "PG-13", "Avengers", 2021 });

            migrationBuilder.InsertData(
                table: "MovieInputs",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "George Lucas", null, "", "The O.G.", "PG", "Star Wars", 1977 });

            migrationBuilder.InsertData(
                table: "MovieInputs",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Drama", "Boaz Yakin", null, "", "A real tear-jerker.", "PG", "Avengers", 2000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieInputs");
        }
    }
}
