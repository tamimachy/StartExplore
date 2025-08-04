using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StartExplore.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingdataforDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2bae93b2-72a0-469e-913b-d6f722637692"), "Medium" },
                    { new Guid("30af42c1-0537-40be-990f-dce77c111851"), "Hard" },
                    { new Guid("896257d8-e4ad-4935-8b44-6150aa6df470"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("14dc09b4-8ee1-407a-8970-8aaaa8b030f9"), "TC", "Tamima Chy", "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpg" },
                    { new Guid("51ea1d8b-b86f-4f95-bdf0-82561b849aa4"), "NSN", "Nelson", "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpg" },
                    { new Guid("56b4d807-535c-46b7-9a2e-421ca3f1680f"), "WGN", "Wellington", "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpg" },
                    { new Guid("5c665ed5-f805-4025-a9d8-f569d895a8ce"), "BOP", "Bay of Plenty", null },
                    { new Guid("8d62d14a-867b-432b-99ed-198eda6047bc"), "STL", "Southland", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("2bae93b2-72a0-469e-913b-d6f722637692"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("30af42c1-0537-40be-990f-dce77c111851"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("896257d8-e4ad-4935-8b44-6150aa6df470"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("14dc09b4-8ee1-407a-8970-8aaaa8b030f9"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("51ea1d8b-b86f-4f95-bdf0-82561b849aa4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("56b4d807-535c-46b7-9a2e-421ca3f1680f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5c665ed5-f805-4025-a9d8-f569d895a8ce"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8d62d14a-867b-432b-99ed-198eda6047bc"));
        }
    }
}
