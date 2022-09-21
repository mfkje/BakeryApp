using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class paulusertest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "b2a3b573-c857-4ba6-ad96-716bdbface48");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "485002eb-8295-4fcf-b1b2-744905fdfed6", "AQAAAAEAACcQAAAAEHN4iVpY2X4uSF6rE+F9w2NuTyZNZCPWuSUeeEHY3/JG6n0dKe6aT+FdezLJuVn/9A==", "4ef3b6ea-0ea3-4f5c-992e-fd8df4c18ab3" });
        }
    }
}
