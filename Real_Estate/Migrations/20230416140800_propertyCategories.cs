using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Real_Estate.Migrations
{
    public partial class propertyCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51d0771e-de96-4882-a01e-8f0b9949e90c",
                column: "ConcurrencyStamp",
                value: "b37c9c15-fd14-48bd-a376-51042f7e1ffe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c965850-234a-4d90-9c24-024ebfac6f20",
                column: "ConcurrencyStamp",
                value: "f7c0b358-f5e5-421c-a79d-9f5ea0cf1ad3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb63abec-98f5-448e-8f56-302fafd16df4",
                column: "ConcurrencyStamp",
                value: "b98be86f-f9ca-4826-bf8c-b3547217e915");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1f3ffc8-a414-4789-8ee9-7bee06240139", new DateTime(2023, 4, 16, 22, 8, 0, 428, DateTimeKind.Local).AddTicks(7263), "AQAAAAEAACcQAAAAEGacIKcNrlK3KdYR2qxpV4w83wfj+Nh6FOXU28jr8x+8RlDpfIX8brwkw4AsO6NWag==", "b9ab82e8-d05a-4ae7-a5ff-98f88819bd17" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51d0771e-de96-4882-a01e-8f0b9949e90c",
                column: "ConcurrencyStamp",
                value: "ae72ecc7-1443-4c89-ac98-265e6f48f1cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c965850-234a-4d90-9c24-024ebfac6f20",
                column: "ConcurrencyStamp",
                value: "25f16c6d-a0ab-491c-94fe-9d8d25a9b658");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb63abec-98f5-448e-8f56-302fafd16df4",
                column: "ConcurrencyStamp",
                value: "a9a55e61-b318-4ddc-8037-ad6247c7171b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20be0226-6286-4f68-968d-e203fb4ab9f5", new DateTime(2023, 4, 16, 22, 1, 15, 823, DateTimeKind.Local).AddTicks(5993), "AQAAAAEAACcQAAAAECZcdVhh6mtLuonKBEDenYSH6DMhHNa0GJ8+/Sb+nr8jlRuzo+ja76FSHkIOJdSG2A==", "abc5d634-9bd9-4b9a-8278-d5ff2c5093b7" });
        }
    }
}
