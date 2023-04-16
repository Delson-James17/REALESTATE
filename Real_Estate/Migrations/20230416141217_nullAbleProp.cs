using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Real_Estate.Migrations
{
    public partial class nullAbleProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstateProperties_PropertyCategories_PropertyCategoryId",
                table: "EstateProperties");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyCategoryId",
                table: "EstateProperties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51d0771e-de96-4882-a01e-8f0b9949e90c",
                column: "ConcurrencyStamp",
                value: "d3f4668b-8d3e-4681-8318-2587bdd4c433");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c965850-234a-4d90-9c24-024ebfac6f20",
                column: "ConcurrencyStamp",
                value: "fb912f2b-3044-49bc-a536-2913cb7a87cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb63abec-98f5-448e-8f56-302fafd16df4",
                column: "ConcurrencyStamp",
                value: "f3d05143-68de-4fbb-9406-4f624115386a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7546a0e5-accb-4bff-9c5e-1d44116093ed", new DateTime(2023, 4, 16, 22, 12, 17, 621, DateTimeKind.Local).AddTicks(3530), "AQAAAAEAACcQAAAAEL6hX7umGjLy0TqfDd5A8lpB6cuUXMoNZR7PJPRd5iPEn3nhn66oaEvDFdvVU18R1g==", "aeb11f64-944c-4df9-b642-a6a18fea304a" });

            migrationBuilder.AddForeignKey(
                name: "FK_EstateProperties_PropertyCategories_PropertyCategoryId",
                table: "EstateProperties",
                column: "PropertyCategoryId",
                principalTable: "PropertyCategories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstateProperties_PropertyCategories_PropertyCategoryId",
                table: "EstateProperties");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyCategoryId",
                table: "EstateProperties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_EstateProperties_PropertyCategories_PropertyCategoryId",
                table: "EstateProperties",
                column: "PropertyCategoryId",
                principalTable: "PropertyCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
