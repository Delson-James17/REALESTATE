using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Real_Estate.Migrations
{
    public partial class changeUsertoOwners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51d0771e-de96-4882-a01e-8f0b9949e90c",
                column: "ConcurrencyStamp",
                value: "48b6a811-50d2-4b35-9e47-72ebb66dfa24");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c965850-234a-4d90-9c24-024ebfac6f20",
                column: "ConcurrencyStamp",
                value: "2dc0d888-febf-4624-98aa-828e90657596");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb63abec-98f5-448e-8f56-302fafd16df4",
                column: "ConcurrencyStamp",
                value: "e1a0ed66-1d54-4a34-a565-a488b5bc8dc7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "227053a7-4a8b-4ec2-83a3-fbcfd598457f", new DateTime(2023, 4, 19, 19, 31, 29, 739, DateTimeKind.Local).AddTicks(9251), "AQAAAAEAACcQAAAAEBqt5b5snJpeHj3GFQ+ZZ/0HEkjt5ns9xRnAjd+P5CGc4zoC3itOKN+5vLS+S66NGA==", "e50d8ee7-d7d1-418b-9a1b-31ca40476551" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51d0771e-de96-4882-a01e-8f0b9949e90c",
                column: "ConcurrencyStamp",
                value: "b35ad27f-61a7-41d2-bffb-67c3c5e54fb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c965850-234a-4d90-9c24-024ebfac6f20",
                column: "ConcurrencyStamp",
                value: "e85059fc-10aa-4012-9c56-57ae179439aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb63abec-98f5-448e-8f56-302fafd16df4",
                column: "ConcurrencyStamp",
                value: "9bc504f9-5059-49aa-96c1-860fafff2a6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55b0dbdc-4de7-44b0-a722-f78efaebed06", new DateTime(2023, 4, 19, 19, 27, 12, 730, DateTimeKind.Local).AddTicks(9087), "AQAAAAEAACcQAAAAECAYO6EqtEAzsjta//mce7gqgX/pnNTh1mMy30gJx8MEdDm0xgXYo/JPSq46PGLAAQ==", "8d4718e3-c554-443d-bcec-aaef1b99a0a4" });
        }
    }
}
