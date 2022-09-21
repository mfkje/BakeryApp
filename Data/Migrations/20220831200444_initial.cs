using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "278626c5-c5c1-4a58-a217-71c61a27137e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cbd379c-4e40-4efb-8433-800d13968751", "AQAAAAEAACcQAAAAEIYVgN3cX8vx7O7XW6LwUgA6ux/PCNvgIhPGXdPG0uRKZqPSELJen4q7OXTxFwu70Q==", "e6d9256b-3626-48eb-881b-2cd815e50c1c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "a5ff47f2-4800-4cc5-84a9-a839d93399da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4c99970-fb11-428a-9c17-ec06924473b8", "AQAAAAEAACcQAAAAEJrKAs6wa+irNvSrStTZsZbxZ5tK+yJbnoboGAo7RaA5Eug9Ik8MKE2rgEOPthjG3w==", "f3b982f3-d9e8-4ba2-b7fe-cb1666de2b2e" });
        }
    }
}
