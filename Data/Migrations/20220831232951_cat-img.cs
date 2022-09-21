using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class catimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "145f1c56-4f2d-4fd2-9332-6687d56004ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0af91150-8700-4138-832a-103c11176589", "AQAAAAEAACcQAAAAEGZORjJVq6yN51RlgeWwt0P6DRZS4rj/ASbssIxZ+EjSpSeShi4KWjRa/5BhDr9Zvg==", "0b4f256f-84cd-4582-b6b3-de2dfe3a57f7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Categories");

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
