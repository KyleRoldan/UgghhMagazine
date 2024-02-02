using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ugghhMagazine.Migrations
{
    public partial class UpdateUserProfileBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                column: "ConcurrencyStamp",
                value: "bf02e56b-9be5-4c8f-b455-fbb0bedb3a73");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d97b3ab0-a500-43d2-a461-e8086070444a", "AQAAAAEAACcQAAAAEBb9qfGu11N+T4Ct8VHMDFlkk1cQB6E7CG/Z4ruDUC4+/JH81NstIxdldf4/f9hjRw==", "6093a961-229f-40b6-bdb6-57d9a2f1468a" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 26, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 21, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 16, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 24, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 19, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 1, 11, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 1, 23, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 1, 13, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 1, 17, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 1, 20, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 1, 14, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 1, 22, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 1, 18, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 1, 15, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 1, 12, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 1, 10, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 1, 25, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 1, 9, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 1, 8, 0, 16, 9, 748, DateTimeKind.Local).AddTicks(2740));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
