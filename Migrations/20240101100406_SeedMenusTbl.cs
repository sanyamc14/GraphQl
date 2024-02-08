using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NewGraphQL.Migrations
{
    /// <inheritdoc />
    public partial class SeedMenusTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, " very clasy burger", "Classic Burger", 39.890000000000001 },
                    { 2, " very buttery burger", "Butter Burger", 49.890000000000001 },
                    { 3, " very cheesy burger", "Cheese Burger", 59.890000000000001 },
                    { 4, " Samosa Inside burger", "Samosa Burger", 69.890000000000001 },
                    { 5, " Paneer inisde burger", "Paneer Burger", 89.890000000000001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
