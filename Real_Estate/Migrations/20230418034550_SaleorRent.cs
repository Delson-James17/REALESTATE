using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Real_Estate.Migrations
{
    public partial class SaleorRent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceifRent",
                table: "EstateProperties");

            migrationBuilder.RenameColumn(
                name: "PriceifSale",
                table: "EstateProperties",
                newName: "Price");

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "EstateProperties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SaleOrRentModelId",
                table: "EstateProperties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SaleorRentModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleorRentModel", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_EstateProperties_SaleOrRentModelId",
                table: "EstateProperties",
                column: "SaleOrRentModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstateProperties_SaleorRentModel_SaleOrRentModelId",
                table: "EstateProperties",
                column: "SaleOrRentModelId",
                principalTable: "SaleorRentModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstateProperties_SaleorRentModel_SaleOrRentModelId",
                table: "EstateProperties");

            migrationBuilder.DropTable(
                name: "SaleorRentModel");

            migrationBuilder.DropIndex(
                name: "IX_EstateProperties_SaleOrRentModelId",
                table: "EstateProperties");

            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "EstateProperties");

            migrationBuilder.DropColumn(
                name: "SaleOrRentModelId",
                table: "EstateProperties");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "EstateProperties",
                newName: "PriceifSale");

            migrationBuilder.AddColumn<double>(
                name: "PriceifRent",
                table: "EstateProperties",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51d0771e-de96-4882-a01e-8f0b9949e90c",
                column: "ConcurrencyStamp",
                value: "2431a8bf-f082-4828-af2a-9c2121dc4e0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c965850-234a-4d90-9c24-024ebfac6f20",
                column: "ConcurrencyStamp",
                value: "b94f786e-3911-4bf1-893c-95c959c81af0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb63abec-98f5-448e-8f56-302fafd16df4",
                column: "ConcurrencyStamp",
                value: "de3b1e4a-dbac-48fb-b1ac-b1dde775c1ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce643f95-ed6a-4c92-9ba2-7e6baf9c168d", new DateTime(2023, 4, 18, 10, 26, 29, 251, DateTimeKind.Local).AddTicks(9349), "AQAAAAEAACcQAAAAEPvkf8FbPzv9cyKKk455DRV4tv54N6TFQesC8hR3tINJXMeV+wh6/RPQRcvvnScP0Q==", "6db7a3e7-cc16-4ea3-a37a-e524e25bfc83" });
        }
    }
}
