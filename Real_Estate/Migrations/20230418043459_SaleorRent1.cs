using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Real_Estate.Migrations
{
    public partial class SaleorRent1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstateProperties_SaleorRentModel_SaleOrRentModelId",
                table: "EstateProperties");

            migrationBuilder.AlterColumn<int>(
                name: "SaleOrRentModelId",
                table: "EstateProperties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerName",
                table: "EstateProperties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51d0771e-de96-4882-a01e-8f0b9949e90c",
                column: "ConcurrencyStamp",
                value: "b5a1744a-268b-4b6f-9f11-773328d04047");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c965850-234a-4d90-9c24-024ebfac6f20",
                column: "ConcurrencyStamp",
                value: "a0976bcc-c875-4c58-8324-08a35ab6d826");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb63abec-98f5-448e-8f56-302fafd16df4",
                column: "ConcurrencyStamp",
                value: "38d76719-4a4f-47a9-ae9c-515479bd8e65");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44207df7-f6ce-42a4-842c-d89efc38edfc", new DateTime(2023, 4, 18, 12, 34, 59, 433, DateTimeKind.Local).AddTicks(4295), "AQAAAAEAACcQAAAAEJHSf6A/lavE4j3PjdovL61PGAgEaCW7SkZ4fh18cGuWUTZGS/Cpin7YAKZvnS6jXg==", "a74f885f-cbaf-43c4-b854-0c96cbeed4ca" });

            migrationBuilder.AddForeignKey(
                name: "FK_EstateProperties_SaleorRentModel_SaleOrRentModelId",
                table: "EstateProperties",
                column: "SaleOrRentModelId",
                principalTable: "SaleorRentModel",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstateProperties_SaleorRentModel_SaleOrRentModelId",
                table: "EstateProperties");

            migrationBuilder.AlterColumn<int>(
                name: "SaleOrRentModelId",
                table: "EstateProperties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerName",
                table: "EstateProperties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51d0771e-de96-4882-a01e-8f0b9949e90c",
                column: "ConcurrencyStamp",
                value: "20a71588-c4a9-4336-8aec-1aef5e7e9714");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c965850-234a-4d90-9c24-024ebfac6f20",
                column: "ConcurrencyStamp",
                value: "1168cada-6d0c-4951-b4fa-214678bfd367");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb63abec-98f5-448e-8f56-302fafd16df4",
                column: "ConcurrencyStamp",
                value: "2e365237-2de1-41de-b8b2-0e1c1cefbf31");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d1af6ac-0047-4e1d-8552-cdb080e2f322", new DateTime(2023, 4, 18, 11, 45, 49, 713, DateTimeKind.Local).AddTicks(6449), "AQAAAAEAACcQAAAAEFvYqU6kFyB86hoD0mBC+phFSGsKC2C/pVZE7XU4PtzSypnFqdNaOXRUH0gXQ+aruw==", "f18a33f6-ee34-4c37-8c70-88e7023bbc72" });

            migrationBuilder.AddForeignKey(
                name: "FK_EstateProperties_SaleorRentModel_SaleOrRentModelId",
                table: "EstateProperties",
                column: "SaleOrRentModelId",
                principalTable: "SaleorRentModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
