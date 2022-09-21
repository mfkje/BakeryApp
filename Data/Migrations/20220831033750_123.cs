using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "8f964e41-c21a-4ccf-abf7-b79fe2878b1c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "906faf7d-d034-47a4-9dcf-be01cddbb22b", "AQAAAAEAACcQAAAAEJaffzasQTHsTbneFwDRq+SzTbv4pSQ3kEhveHCKqyCA5yM5XdKccx+tRJAVkaJLKg==", "3993c62b-6421-4377-b51c-978e3264534c" });
        }
    }
}
