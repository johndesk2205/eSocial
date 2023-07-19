using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eSocial.Dal.Migrations
{
    /// <inheritdoc />
    public partial class SeedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedAt", "LastUpdate" },
                values: new object[,]
                {
                    { 1, "Fullstack Developer", new DateTime(2023, 7, 19, 0, 13, 11, 357, DateTimeKind.Local).AddTicks(5892), new DateTime(2023, 7, 19, 0, 13, 11, 357, DateTimeKind.Local).AddTicks(5981) },
                    { 2, "Blazor Developer", new DateTime(2023, 7, 19, 0, 13, 11, 357, DateTimeKind.Local).AddTicks(5987), new DateTime(2023, 7, 19, 0, 13, 11, 357, DateTimeKind.Local).AddTicks(5991) },
                    { 3, ".Net Developer", new DateTime(2023, 7, 19, 0, 13, 11, 357, DateTimeKind.Local).AddTicks(5996), new DateTime(2023, 7, 19, 0, 13, 11, 357, DateTimeKind.Local).AddTicks(6000) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
