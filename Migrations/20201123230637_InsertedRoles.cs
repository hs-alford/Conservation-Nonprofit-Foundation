using Microsoft.EntityFrameworkCore.Migrations;

namespace Treehuggers_WebApp01.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03b5916e-be82-4970-a3a6-7eee5632cbaa", "d9fff817-9fd6-4c63-8d5b-ae3b617b8d2e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f70163e9-06cc-4f95-9604-4ac7aa08b7ec", "47bd9f28-d230-426b-afed-1b32faf54125", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "053465bc-5065-463a-9c76-32420f5acdf7", "167837b1-34cc-4068-8d1e-ef9b58e91d07", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03b5916e-be82-4970-a3a6-7eee5632cbaa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "053465bc-5065-463a-9c76-32420f5acdf7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f70163e9-06cc-4f95-9604-4ac7aa08b7ec");
        }
    }
}
