using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class migration_products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "7de8680b-9466-4b2e-8c94-bf2fa254b21e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbac0436-e6a1-4ed5-a04e-e997b1f51b3c", "AQAAAAEAACcQAAAAEH4t7b4L8D/CN1wYmQtfZyuZzW9FBvoG6V8+arktQd8qkhiq8jcb2+sWUuY2ZIGWAQ==", "717facd2-bb2b-4912-b14e-0d105ebdeed4" });
        }
    }
}
