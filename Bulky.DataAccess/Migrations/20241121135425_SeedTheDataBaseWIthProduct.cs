using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedTheDataBaseWIthProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "CreatedByUserId", "CreationDate", "Description", "Duration", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", 1, "admin", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", new TimeSpan(30, 0, 0, 0, 0), "SWD9999001", "", 99.0, 90.0, 80.0, 85.0, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortune of Time" },
                    { 2, "Nancy Hoover", 1, "editor", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", new TimeSpan(60, 0, 0, 0, 0), "CAW777777701", "", 40.0, 30.0, 20.0, 25.0, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Skies" },
                    { 3, "Julian Button", 1, "author", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", new TimeSpan(90, 0, 0, 0, 0), "RITO5555501", "", 55.0, 50.0, 35.0, 40.0, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vanish in the Sunset" },
                    { 4, "Abby Muscles", 2, "reviewer", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", new TimeSpan(120, 0, 0, 0, 0), "WS3333333301", "", 70.0, 65.0, 55.0, 60.0, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cotton Candy" },
                    { 5, "Ron Parker", 2, "editor", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", new TimeSpan(150, 0, 0, 0, 0), "SOTJ1111111101", "", 30.0, 27.0, 20.0, 25.0, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock in the Ocean" },
                    { 6, "Laura Phantom", 3, "admin", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", new TimeSpan(180, 0, 0, 0, 0), "FOT000000001", "", 25.0, 23.0, 20.0, 22.0, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leaves and Wonders" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
