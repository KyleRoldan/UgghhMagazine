using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ugghhMagazine.Migrations
{
    public partial class IsAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsAdmin",
                table: "UserProfiles",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                column: "ConcurrencyStamp",
                value: "f53ab67b-e743-4b3e-9b4b-0bb7db0d653c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99a8fec1-5343-4cf9-bf5e-e8d23ee4c206", "AQAAAAEAACcQAAAAELeSgYP2lIZHEw12BEWgX+eNGXsVc24uln0HE2RMGbA5s4aTDB0RZSSwuke7DH8GXg==", "8dbdc335-13dc-4394-9b00-31f1471d918d" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 25, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 20, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 15, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 23, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 18, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 1, 10, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 1, 22, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 1, 12, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 1, 16, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 1, 19, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 1, 13, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 1, 21, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 1, 17, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 1, 14, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 1, 11, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 1, 9, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 1, 24, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 1, 8, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 1, 7, 23, 21, 58, 344, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsAdmin",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsAdmin",
                table: "UserProfiles",
                type: "text",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                column: "ConcurrencyStamp",
                value: "90eb1f62-b630-4535-a053-c8a4a3c6834c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aef7f1d4-6069-40ea-85c5-66ae241acf7b", "AQAAAAEAACcQAAAAELOq/3Uh0MgNFtpTFwDT4YycYDxPM8edHt3xvEVb+bW/ntrMPfj9v7mDIioGCE+jag==", "c7fb2fed-e756-48f0-b660-7c600160ca43" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 23, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 18, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 13, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 21, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 16, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 1, 8, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 1, 20, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 1, 10, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 1, 14, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 1, 17, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 1, 11, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 1, 19, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 1, 15, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 1, 12, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 1, 9, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 1, 7, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 1, 22, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 1, 6, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 1, 5, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsAdmin",
                value: null);
        }
    }
}
