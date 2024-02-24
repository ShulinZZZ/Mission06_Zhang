using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Zhang.Migrations
{
    /// <inheritdoc />
    public partial class InitialOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "year",
                table: "movies",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "movies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "movies",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "lent",
                table: "movies",
                newName: "Lent");

            migrationBuilder.RenameColumn(
                name: "edited",
                table: "movies",
                newName: "Edited");

            migrationBuilder.RenameColumn(
                name: "director",
                table: "movies",
                newName: "Director");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "movies",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "category",
                table: "movies",
                newName: "CategoryName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "movies",
                newName: "year");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "movies",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "movies",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "Lent",
                table: "movies",
                newName: "lent");

            migrationBuilder.RenameColumn(
                name: "Edited",
                table: "movies",
                newName: "edited");

            migrationBuilder.RenameColumn(
                name: "Director",
                table: "movies",
                newName: "director");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "movies",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "movies",
                newName: "category");
        }
    }
}
