using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RentalPoint.Api.Migrations
{
    /// <inheritdoc />
    public partial class addSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a3c8e5d5-3f42-4c77-ae5c-1c9e1e4d3b8e"), "Toys" },
                    { new Guid("b1c5e8a6-3f42-4c77-ae5c-1c9e1e4d3a8b"), "Outdoor" },
                    { new Guid("b6ab5de6-8f1f-4dd4-8e14-b7f5b7e6c0ab"), "Furniture" },
                    { new Guid("b9c5e8a6-3f42-4c77-ae5c-1c9e1e4d3a8b"), "Sports" },
                    { new Guid("c5e8a1b6-4d7f-4b8e-9d6b-4c1e6b8a8f2c"), "Books" },
                    { new Guid("d6f1e1d6-41f9-4b5e-9aeb-9d6b657b5c1a"), "Electronics" },
                    { new Guid("f8a7d5e4-1e8b-4d56-8a0a-8e5f6c7d7c8d"), "Tools" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("4b3e2a1c-5d6f-7890-a1b2-c3d4e5f67890"), "jane.smith@example.com", "Jane", "Smith", "098-765-4321" },
                    { new Guid("c1a2b3d4-e5f6-7890-a1b2-c3d4e5f67890"), "bob.brown@example.com", "Bob", "Brown", "345-678-9012" },
                    { new Guid("d4e5f6a7-b8c9-0a1b-2c3d-4e5f6a7b8c9d"), "charlie.davis@example.com", "Charlie", "Davis", "456-789-0123" },
                    { new Guid("e1f2c3b4-a5d6-7890-b1c2-d3e4f5a6b7c8"), "edward.wilson@example.com", "Edward", "Wilson", "678-901-2345" },
                    { new Guid("f1e2d3c4-b5a6-7890-a1b2-c3d4e5f67890"), "diana.evans@example.com", "Diana", "Evans", "567-890-1234" },
                    { new Guid("f4a1b2c3-d4e5-6789-abcd-ef0123456789"), "john.doe@example.com", "John", "Doe", "123-456-7890" },
                    { new Guid("f9a8b7c6-d5e4-3f2a-1b0c-9e8f7a6b5c4d"), "alice.johnson@example.com", "Alice", "Johnson", "234-567-8901" }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Description", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("a4b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"), "Summer Sale", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3c2d3e4-f5a6-7890-a1b2-c3d4e5f67890"), "Labor Day Sale", new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4c2d3e4-f5a6-7890-a1b2-c3d4e5f67890"), "Black Friday Deals", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4d2e3f4-a5b6-7890-a1b2-c3d4e5f67890"), "Christmas Sale", new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e7f2c3d4-b5c6-7890-a1b2-c3d4e5f67890"), "Spring Clearance", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2a2b3c4-d5e6-7890-a1b2-c3d4e5f67890"), "Fall Specials", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7a2b3c4-d5e6-7890-a1b2-c3d4e5f67890"), "New Year Discount", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "Description", "IsRented", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("a1b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"), new Guid("b6ab5de6-8f1f-4dd4-8e14-b7f5b7e6c0ab"), "A comfortable office chair.", false, "Chair", 150.00m },
                    { new Guid("b2c3d4e5-a6f7-89a0-b1c2-d3e4f5a6b7c8"), new Guid("b1c5e8a6-3f42-4c77-ae5c-1c9e1e4d3a8b"), "A waterproof camping tent.", false, "Tent", 300.00m },
                    { new Guid("c1d2e3f4-a5b6-7890-a1b2-c3d4e5f67890"), new Guid("f8a7d5e4-1e8b-4d56-8a0a-8e5f6c7d7c8d"), "A powerful electric drill.", false, "Drill", 100.00m },
                    { new Guid("c2d3e4f5-a6b7-8901-a1b2-c3d4e5f67890"), new Guid("c5e8a1b6-4d7f-4b8e-9d6b-4c1e6b8a8f2c"), "A cookbook for home chefs.", false, "Cookbook", 30.00m },
                    { new Guid("e1f2c3a4-b5c6-7890-a1b2-c3d4e5f67890"), new Guid("b9c5e8a6-3f42-4c77-ae5c-1c9e1e4d3a8b"), "A regulation soccer ball.", false, "Soccer Ball", 25.00m },
                    { new Guid("f2b3c4d5-e5f6-7890-a1b2-c3d4e5f67890"), new Guid("a3c8e5d5-3f42-4c77-ae5c-1c9e1e4d3b8e"), "A collectible action figure.", false, "Action Figure", 15.00m },
                    { new Guid("f2b3c4d5-e6f7-89a0-b1c2-d3e4f5a6b7c8"), new Guid("d6f1e1d6-41f9-4b5e-9aeb-9d6b657b5c1a"), "A high-performance laptop.", false, "Laptop", 1200.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4b3e2a1c-5d6f-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c1a2b3d4-e5f6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d4e5f6a7-b8c9-0a1b-2c3d-4e5f6a7b8c9d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e1f2c3b4-a5d6-7890-b1c2-d3e4f5a6b7c8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f1e2d3c4-b5a6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f4a1b2c3-d4e5-6789-abcd-ef0123456789"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f9a8b7c6-d5e4-3f2a-1b0c-9e8f7a6b5c4d"));

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("a4b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("b3c2d3e4-f5a6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("b4c2d3e4-f5a6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("c4d2e3f4-a5b6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("e7f2c3d4-b5c6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("f2a2b3c4-d5e6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("f7a2b3c4-d5e6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b2c3d4e5-a6f7-89a0-b1c2-d3e4f5a6b7c8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c1d2e3f4-a5b6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c2d3e4f5-a6b7-8901-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e1f2c3a4-b5c6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f2b3c4d5-e5f6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f2b3c4d5-e6f7-89a0-b1c2-d3e4f5a6b7c8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3c8e5d5-3f42-4c77-ae5c-1c9e1e4d3b8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1c5e8a6-3f42-4c77-ae5c-1c9e1e4d3a8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6ab5de6-8f1f-4dd4-8e14-b7f5b7e6c0ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b9c5e8a6-3f42-4c77-ae5c-1c9e1e4d3a8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5e8a1b6-4d7f-4b8e-9d6b-4c1e6b8a8f2c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6f1e1d6-41f9-4b5e-9aeb-9d6b657b5c1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8a7d5e4-1e8b-4d56-8a0a-8e5f6c7d7c8d"));
        }
    }
}
