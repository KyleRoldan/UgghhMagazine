using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ugghhMagazine.Migrations
{
    public partial class ChangeIsAdminType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
{
    // Add a new temporary column OldIsAdmin
    migrationBuilder.AddColumn<string>(
        name: "OldIsAdmin",
        table: "UserProfiles",
        type: "text",
        nullable: true);

    // Update existing data in the new column
    migrationBuilder.Sql("UPDATE UserProfiles SET OldIsAdmin = IsAdmin");

    // Drop the existing IsAdmin column
    migrationBuilder.DropColumn(
        name: "IsAdmin",
        table: "UserProfiles");

    // Add a new IsAdmin column with boolean type using the old data
    migrationBuilder.AddColumn<bool>(
        name: "IsAdmin",
        table: "UserProfiles",
        type: "boolean",
        nullable: false,
        defaultValue: false,
        // Specify the USING clause to perform the type conversion
        defaultValueSql: "OldIsAdmin::boolean");

    // Drop the temporary OldIsAdmin column
    migrationBuilder.DropColumn(
        name: "OldIsAdmin",
        table: "UserProfiles");
}
            
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                column: "ConcurrencyStamp",
                value: "763be343-e3bb-45d0-85f4-60fe25b7dca2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27defba9-b83d-4a11-8ef2-7129b8189089", "AQAAAAEAACcQAAAAEB7usTTVRbSNJsZSil9dR0k2DtmjPMaqfE+5wXSHJgXqKUHHAuvBdud4ooh8SfLg7A==", "b50472d5-8650-471b-8915-51a0aa8c3636" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 27, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 22, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 17, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 25, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 20, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 1, 12, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 1, 24, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 1, 14, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 1, 18, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 1, 21, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 1, 15, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 1, 23, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 1, 19, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 1, 16, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 1, 13, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 1, 11, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 1, 26, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 1, 10, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 1, 9, 15, 52, 52, 723, DateTimeKind.Local).AddTicks(4100));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
