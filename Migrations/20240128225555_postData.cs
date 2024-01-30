using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ugghhMagazine.Migrations
{
    public partial class postData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Author", "Date" },
                values: new object[] { "Author B", new DateTime(2024, 1, 18, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Date" },
                values: new object[] { "Author C", new DateTime(2024, 1, 13, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Author", "CategoryId", "Content", "Date", "IdentityUserId", "Title", "UserProfileId" },
                values: new object[,]
                {
                    { 4, "Pizza Lover", 1, "Exploring the pizza world!", new DateTime(2024, 1, 21, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(750), null, "The Quest for the Perfect Pizza", 1 },
                    { 5, "Tech Dancer", 2, "Innovative dance moves with robots!", new DateTime(2024, 1, 16, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(760), null, "Dancing with Robots", 1 },
                    { 6, "VR Artist", 3, "Immersive art experiences!", new DateTime(2024, 1, 8, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(760), null, "Surreal Paintings in Virtual Reality", 1 },
                    { 7, "Aqua Weaver", 1, "Unique aquatic crafting!", new DateTime(2024, 1, 20, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(760), null, "Adventures in Underwater Basket Weaving", 1 },
                    { 8, "Fort Architect", 2, "Building the ultimate pillow fortress!", new DateTime(2024, 1, 10, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(760), null, "Epic Pillow Fort Construction", 1 },
                    { 9, "Sock Scientist", 3, "Unraveling the mysteries of sock pairs!", new DateTime(2024, 1, 14, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(760), null, "The Science of Sock Matching", 1 },
                    { 10, "Budget Astronaut", 1, "Exploring the cosmos without breaking the bank!", new DateTime(2024, 1, 17, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(770), null, "Space Travel on a Budget", 1 },
                    { 11, "Chef Chronos", 2, "Cooking across different eras!", new DateTime(2024, 1, 11, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(770), null, "Time-Traveling Cookbook Adventures", 1 },
                    { 12, "Ink Detective", 3, "Unveiling hidden messages!", new DateTime(2024, 1, 19, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(770), null, "Secrets of Invisible Ink", 1 },
                    { 13, "Paper Pilot", 1, "Achieving new heights with paper airplanes!", new DateTime(2024, 1, 15, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(770), null, "World Record for Paper Airplane Flight", 1 },
                    { 14, "Zero-G Juggler", 2, "Juggling feats in outer space!", new DateTime(2024, 1, 12, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(770), null, "Extreme Juggling in Zero Gravity", 1 },
                    { 15, "Entomophagist", 3, "Culinary adventures with insects!", new DateTime(2024, 1, 9, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(780), null, "Gourmet Insect Tasting", 1 },
                    { 16, "Avian Adrenaline Junkie", 1, "Soaring through the skies with birds!", new DateTime(2024, 1, 7, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(780), null, "Skydiving with Feathered Friends", 1 },
                    { 17, "Extraterrestrial Dancer", 2, "Interstellar dance language!", new DateTime(2024, 1, 22, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(780), null, "Alien Communication through Dance", 1 },
                    { 18, "Quantum Baker", 3, "Baking with a quantum twist!", new DateTime(2024, 1, 6, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(780), null, "Mysteries of Quantum Baking", 1 },
                    { 19, "Unicorn Enthusiast", 1, "Seek", new DateTime(2024, 1, 5, 17, 55, 55, 31, DateTimeKind.Local).AddTicks(790), null, "Unicorn Tracking Expeditions", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19);

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

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 27, 20, 3, 52, 800, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Date" },
                values: new object[] { "Author b", new DateTime(2024, 1, 27, 20, 3, 52, 800, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Date" },
                values: new object[] { "Author c", new DateTime(2024, 1, 27, 20, 3, 52, 800, DateTimeKind.Local).AddTicks(2660) });
        }
    }
}
