using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NewGraphQL.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartySize = table.Column<int>(type: "int", nullable: false),
                    SpecialRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "https://example.com/categories/appetizers.jpg", "Appetizers" },
                    { 2, "https://example.com/categories/main-course.jpg", "Main Course" },
                    { 3, "https://example.com/categories/desserts.jpg", "Desserts" }
                });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, "Spicy chicken wings served with blue cheese dip.", "https://example.com/menus/chicken-wings.jpg", "Chicken Wings", 9.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, "Grilled steak with mashed potatoes and vegetables.", "https://example.com/menus/steak.jpg", "Steak", 24.5 });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, "Decadent chocolate cake with a scoop of vanilla ice cream.", "https://example.com/menus/chocolate-cake.jpg", "Chocolate Cake", 6.9500000000000002 });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerName", "Email", "PartySize", "PhoneNumber", "ReservationDate", "SpecialRequest" },
                values: new object[,]
                {
                    { 1, "John Doe", "johndoe@example.com", 2, "555-123-4567", new DateTime(2024, 1, 13, 17, 35, 57, 183, DateTimeKind.Local).AddTicks(8236), "No nuts in the dishes, please." },
                    { 2, "Jane Smith", "janesmith@example.com", 4, "555-987-6543", new DateTime(2024, 1, 16, 17, 35, 57, 183, DateTimeKind.Local).AddTicks(8283), "Gluten-free options required." },
                    { 3, "Michael Johnson", "michaeljohnson@example.com", 6, "555-789-0123", new DateTime(2024, 1, 20, 17, 35, 57, 183, DateTimeKind.Local).AddTicks(8286), "Celebrating a birthday." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menus_CategoryId",
                table: "Menus",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Categories_CategoryId",
                table: "Menus",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Categories_CategoryId",
                table: "Menus");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Menus_CategoryId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Menus");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { " very clasy burger", "Classic Burger", 39.890000000000001 });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { " very buttery burger", "Butter Burger", 49.890000000000001 });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { " very cheesy burger", "Cheese Burger", 59.890000000000001 });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 4, " Samosa Inside burger", "Samosa Burger", 69.890000000000001 },
                    { 5, " Paneer inisde burger", "Paneer Burger", 89.890000000000001 }
                });
        }
    }
}
