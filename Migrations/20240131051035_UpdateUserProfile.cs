using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ugghhMagazine.Migrations
{
    public partial class UpdateUserProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsAdmin",
                table: "UserProfiles",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                column: "ConcurrencyStamp",
                value: "8592a63f-981c-4b63-a3fc-6930c6081749");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c32168c2-1967-4fa4-8907-d62a71c38696", "AQAAAAEAACcQAAAAED/lijW2PrOw/rw6tgnB+FZEv4m8dkOh/RLTjx7PpS1X8Zbb1j+6WnddSTIDN+Ti5w==", "090e712e-24e1-4022-9ffe-9a85ead087bc" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 26, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 21, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 16, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 24, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 19, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 1, 11, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 1, 23, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 1, 13, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 1, 17, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 1, 20, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 1, 14, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 1, 22, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 1, 18, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 1, 15, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 1, 12, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 1, 10, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 1, 25, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 1, 9, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 1, 8, 0, 10, 35, 237, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsAdmin",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsAdmin",
                table: "UserProfiles",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

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
    }
}
