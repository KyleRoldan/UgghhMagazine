using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ugghhMagazine.Migrations
{
    public partial class @bool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)

        {

            {
           migrationBuilder.AlterColumn<bool>(
                name: "IsAdmin",
                table: "UserProfiles",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: false);
}
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                column: "ConcurrencyStamp",
                value: "13489061-6201-41aa-a4d5-9247008660b8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f08c4c5e-ca7f-4058-b54f-01db7c56d8b5", "AQAAAAEAACcQAAAAEIV3nUU+bctcE4aXEnO0Rs4uPkKc3g1C7wU657y5XAtJYDjjEBAs3tfbQrv2NA1ZKw==", "2ee6eb50-f4f7-4370-afe3-eb127060fe0e" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 27, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 22, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 17, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 25, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 20, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 1, 12, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 1, 24, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 1, 14, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 1, 18, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 1, 21, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 1, 15, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 1, 23, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 1, 19, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 1, 16, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 1, 13, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 1, 11, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 1, 26, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 1, 10, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 1, 9, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5770));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
