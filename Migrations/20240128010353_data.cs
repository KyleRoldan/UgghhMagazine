using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ugghhMagazine.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Post",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Post",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                column: "ConcurrencyStamp",
                value: "2263ab36-fa78-4da1-a4d6-31d872e777cd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b349be1-db0e-4173-b6ec-f09974a4ce97", "AQAAAAEAACcQAAAAEFNj8ZcVtAnbXq2wEc3m+vufm5FHp7uTDtFNUl/FrfRGBjD/qZQV/iLgwTY+ZF6sGA==", "e99d6b1e-cf51-40e8-9b45-4e1585151c55" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Poetry" },
                    { 2, "Short Story" },
                    { 3, "Opinion" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Author", "CategoryId", "Content", "Date", "IdentityUserId", "Title", "UserProfileId" },
                values: new object[,]
                {
                    { 1, "Author A", 1, "Exciting tech news!", new DateTime(2024, 1, 27, 20, 3, 52, 800, DateTimeKind.Local).AddTicks(2610), null, "A Poem is Poetry", 1 },
                    { 2, "Author b", 2, "Latest fashion trends!", new DateTime(2024, 1, 27, 20, 3, 52, 800, DateTimeKind.Local).AddTicks(2660), null, "A Short Story is Hard to Write", 1 },
                    { 3, "Author c", 3, "Amazing travel adventures!", new DateTime(2024, 1, 27, 20, 3, 52, 800, DateTimeKind.Local).AddTicks(2660), null, "Travel Boom Leads to Gentrification", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Post");

            migrationBuilder.AlterColumn<int>(
                name: "Title",
                table: "Post",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                column: "ConcurrencyStamp",
                value: "6bc7dac5-38b2-484c-a814-fbb6c68d895e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c29226da-a6d4-446c-b83f-379f15a61ee3", "AQAAAAEAACcQAAAAELtHT+rNUFFOy06qVkfgG+r8j5YTKHkLlRT/qTwe8jbqUkDNFbuDdq+Uj4xaPwCFqg==", "8a7a7eea-8750-461f-9c6d-e608492f206d" });
        }
    }
}
