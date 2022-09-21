using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "d30967fa-0d11-4fcf-b4e4-7483d00bf9e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2b2d613-a6cc-498e-9cd7-0ad177b0e9db", "AQAAAAEAACcQAAAAEME0+VvlwVul/YNJQG6blMsCuiw6iIg2vxnHrsMPRGQRSZRqdpTOSlvR86Va7jg1eA==", "71b56403-741f-410e-82e9-66a6a16ed29e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "93d1d220-c201-4341-a91e-cd0983ae50d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d6a7aac-8702-47ef-b715-7cf5e1c2d48f", "AQAAAAEAACcQAAAAEJd7lIkYKaY4lz0ZuZCSI6UyqjN3HpQ4xkKhVIzzCS0+5p8rJW7flgLvslmOaFpMvg==", "8b989688-29cf-4197-b51e-5d33e10a10a3" });
        }
    }
}
