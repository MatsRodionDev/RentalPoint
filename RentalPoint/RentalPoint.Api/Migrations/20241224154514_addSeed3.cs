using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RentalPoint.Api.Migrations
{
    /// <inheritdoc />
    public partial class addSeed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "ClientId", "ItemId", "ItemIsBacked" },
                values: new object[,]
                {
                    { new Guid("f7a2b3c4-d5e6-7890-a1b2-c3d4e5f67891"), new Guid("f4a1b2c3-d4e5-6789-abcd-ef0123456789"), new Guid("a1b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"), false },
                    { new Guid("f7a2b3c4-d5e6-7890-a1b2-c3d4e5f67892"), new Guid("c1a2b3d4-e5f6-7890-a1b2-c3d4e5f67890"), new Guid("a1b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"), false },
                    { new Guid("f7a2b3c4-d5e6-7890-a1b2-c3d4e5f67893"), new Guid("4b3e2a1c-5d6f-7890-a1b2-c3d4e5f67890"), new Guid("e1f2c3a4-b5c6-7890-a1b2-c3d4e5f67890"), false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: new Guid("f7a2b3c4-d5e6-7890-a1b2-c3d4e5f67891"));

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: new Guid("f7a2b3c4-d5e6-7890-a1b2-c3d4e5f67892"));

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: new Guid("f7a2b3c4-d5e6-7890-a1b2-c3d4e5f67893"));
        }
    }
}
