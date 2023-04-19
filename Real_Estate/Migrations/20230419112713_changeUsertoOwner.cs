using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Real_Estate.Migrations
{
    public partial class changeUsertoOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51d0771e-de96-4882-a01e-8f0b9949e90c",
                column: "ConcurrencyStamp",
                value: "772388e3-68bf-4fba-9f00-63fea96c9b81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c965850-234a-4d90-9c24-024ebfac6f20",
                column: "ConcurrencyStamp",
                value: "85580f7a-a2f6-4850-a6a0-8c2248683180");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb63abec-98f5-448e-8f56-302fafd16df4",
                column: "ConcurrencyStamp",
                value: "95e2829a-5e14-46d5-bc6e-25303116c3a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8288b719-8a62-43ef-8037-cfbf11d23d97", new DateTime(2023, 4, 18, 18, 55, 15, 734, DateTimeKind.Local).AddTicks(5757), "AQAAAAEAACcQAAAAEMXNfCxoobqIXPT3JpRFpvFJzBiF6/XtZQFGdcYaRebpTC9Wso5UWWQ3GbVJuzEALQ==", "62d9daee-c87e-4357-9873-483d755def6a" });
        }
    }
}
