using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class catimg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "9b05d3df-1c84-4f64-a6cd-c45ad0aa8f6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d26f586-160a-42a2-8560-08efed9810de", "AQAAAAEAACcQAAAAEEekMB+HXBwwbtALVUF2ybmIlrlEA4G0y0Eb+n+HV1q0UjJd0CSiZij3U8Z7Ikuc7A==", "b7f27cf6-d7f1-4ade-a470-24955b4f388a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
