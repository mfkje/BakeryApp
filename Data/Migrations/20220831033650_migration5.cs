using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "6193cee3-84d1-4a5d-807a-e7f33c87168b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9573aa6c-2d3e-4c01-9df9-5bd335fec06c", "AQAAAAEAACcQAAAAEOGzh1ix1TnTon/JGaglRMeY5jCi3L6RaJG/W4+Sb6wpAyzTwyAfxj7VmxETMdksew==", "8a46c17b-7649-4651-9285-d40bd2c3d826" });
        }
    }
}
