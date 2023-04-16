using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Real_Estate.Migrations
{
    public partial class relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PropertyListViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstateId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyListViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstatePropertyPropertyListViewModel",
                columns: table => new
                {
                    PropertiesId = table.Column<int>(type: "int", nullable: false),
                    PropertyListViewsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstatePropertyPropertyListViewModel", x => new { x.PropertiesId, x.PropertyListViewsId });
                    table.ForeignKey(
                        name: "FK_EstatePropertyPropertyListViewModel_EstateProperties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "EstateProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstatePropertyPropertyListViewModel_PropertyListViewModel_PropertyListViewsId",
                        column: x => x.PropertyListViewsId,
                        principalTable: "PropertyListViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyCategoryPropertyListViewModel",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    PropertyListViewsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyCategoryPropertyListViewModel", x => new { x.CategoriesId, x.PropertyListViewsId });
                    table.ForeignKey(
                        name: "FK_PropertyCategoryPropertyListViewModel_PropertyCategories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "PropertyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyCategoryPropertyListViewModel_PropertyListViewModel_PropertyListViewsId",
                        column: x => x.PropertyListViewsId,
                        principalTable: "PropertyListViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51d0771e-de96-4882-a01e-8f0b9949e90c",
                column: "ConcurrencyStamp",
                value: "9ddb5a31-a598-49ea-b471-f88a64c68e9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c965850-234a-4d90-9c24-024ebfac6f20",
                column: "ConcurrencyStamp",
                value: "f93f5096-b64f-459f-80b4-f1fb98ed2ac9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb63abec-98f5-448e-8f56-302fafd16df4",
                column: "ConcurrencyStamp",
                value: "f67413c4-0827-4fe5-b633-2a2a4674c933");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1a322c8-5207-40c2-acb4-a59a1f500801", new DateTime(2023, 4, 17, 0, 10, 17, 525, DateTimeKind.Local).AddTicks(3812), "AQAAAAEAACcQAAAAED99zuuRJb3Mkv5dIZlzT1v09iM5YkYDmcp8ovSefwFbyVOJR6fYZwbcOdVJGbUajg==", "1668390d-ba73-46e1-a1b9-9b89f280876f" });

            migrationBuilder.CreateIndex(
                name: "IX_EstatePropertyPropertyListViewModel_PropertyListViewsId",
                table: "EstatePropertyPropertyListViewModel",
                column: "PropertyListViewsId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyCategoryPropertyListViewModel_PropertyListViewsId",
                table: "PropertyCategoryPropertyListViewModel",
                column: "PropertyListViewsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstatePropertyPropertyListViewModel");

            migrationBuilder.DropTable(
                name: "PropertyCategoryPropertyListViewModel");

            migrationBuilder.DropTable(
                name: "PropertyListViewModel");

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
        }
    }
}
