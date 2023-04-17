using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheGreatestApiInTheWorldTribute.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "BandId", "Hometown", "Name" },
                values: new object[,]
                {
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Los Angeles, CA", "Red Hot Chili Peppers" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Los Angeles, CA", "Tenacious D" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Age", "BandId", "Name", "Role" },
                values: new object[,]
                {
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), 61, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Chad Smith", "Drummer" },
                    { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), 53, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Jack Black", "Lead" },
                    { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 60, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Anthony Kiedis", "Lead Vocalist" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));

            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
