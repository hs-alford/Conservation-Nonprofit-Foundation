using Microsoft.EntityFrameworkCore.Migrations;

namespace Treehuggers_WebApp01.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ed88bcb-6e9f-473e-a34e-d7f742a80887", "56529226-5088-4b07-90b4-a9da3b15e20b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "22d1554f-878a-452e-a2bf-8f8090e3c1ec", "6119ec8b-7dd4-4c63-9c65-bf25666d07b0", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "55309a37-ca65-46d1-9ffb-5b37d95259de", "941fdece-ade0-4b2a-b42c-b9ad17002979", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ed88bcb-6e9f-473e-a34e-d7f742a80887");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22d1554f-878a-452e-a2bf-8f8090e3c1ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55309a37-ca65-46d1-9ffb-5b37d95259de");

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
    }
}
