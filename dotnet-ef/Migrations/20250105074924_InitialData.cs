using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_ef.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "Description", "Weight" },
                values: new object[,]
                {
                    { new Guid("118eefa8-c6d3-4d20-a591-537931bd2e32"), "Pending Activities", "Activities that are pending", 20 },
                    { new Guid("118eefa8-c6d3-4d20-a591-537931bd2ef2"), "Personal Activities", "Activities that are personal", 50 }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "CategoryId", "CreatedAt", "Description", "Priority", "Title" },
                values: new object[,]
                {
                    { new Guid("118eefa8-c6d3-4d20-a591-537931bd2e17"), new Guid("118eefa8-c6d3-4d20-a591-537931bd2e32"), new DateTime(2025, 1, 5, 8, 30, 52, 0, DateTimeKind.Local), "Description of Task 1", 1, "Task 1" },
                    { new Guid("118eefa8-c6d3-4d20-a591-537931bd2e22"), new Guid("118eefa8-c6d3-4d20-a591-537931bd2ef2"), new DateTime(2025, 1, 5, 8, 30, 52, 0, DateTimeKind.Local), "Description of Task 2", 0, "Task 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("118eefa8-c6d3-4d20-a591-537931bd2e17"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("118eefa8-c6d3-4d20-a591-537931bd2e22"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("118eefa8-c6d3-4d20-a591-537931bd2e32"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("118eefa8-c6d3-4d20-a591-537931bd2ef2"));
        }
    }
}
