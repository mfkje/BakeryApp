using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class migration_products2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "3b55a8d8-0b64-46b4-9df4-2dc73a6958fe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04d5089b-4aa8-4f6f-9c6c-0db7c80d5586", "AQAAAAEAACcQAAAAEA4I1T/yCW2uQ7BfF+BGua0sq76ShvR05R4DOMlyhsj0xkL1wHAB2rO1F1snRu1P9g==", "7cf618a3-9ea6-4aa3-a8b1-9f318b0fce89" });
        }
    }
}
