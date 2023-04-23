using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Real_Estate.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UrlImages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zoomlink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyListViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstateId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyListViewModel", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OwnerSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    startTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnerSchedules_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "EstateProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlImages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaleOrRentModelId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyCategoryId = table.Column<int>(type: "int", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstateProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstateProperties_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstateProperties_PropertyCategories_PropertyCategoryId",
                        column: x => x.PropertyCategoryId,
                        principalTable: "PropertyCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EstateProperties_SaleorRentModel_SaleOrRentModelId",
                        column: x => x.SaleOrRentModelId,
                        principalTable: "SaleorRentModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnersId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OwnerScheduleId = table.Column<int>(type: "int", nullable: false),
                    EstatePropertyId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_OwnersId",
                        column: x => x.OwnersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_EstateProperties_EstatePropertyId",
                        column: x => x.EstatePropertyId,
                        principalTable: "EstateProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_OwnerSchedules_OwnerScheduleId",
                        column: x => x.OwnerScheduleId,
                        principalTable: "OwnerSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "51d0771e-de96-4882-a01e-8f0b9949e90c", "0d6f6847-205a-419d-a91d-069ae8f3b30c", "Owner", "OWNER" },
                    { "5c965850-234a-4d90-9c24-024ebfac6f20", "3b83d67c-2ec1-48b3-9ff2-8e764806ce90", "Client", "CLIENT" },
                    { "fb63abec-98f5-448e-8f56-302fafd16df4", "65897fc0-0d96-46a9-bf0c-db024ca9a483", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UrlImages", "UserName", "Zoomlink" },
                values: new object[,]
                {
                    { "62550723-3df6-4886-80c0-5ff90804ec07", 0, "Laguna", 23, "33e2ca42-fc35-4a75-9eca-ce564a3283c9", new DateTime(2023, 4, 22, 15, 1, 38, 432, DateTimeKind.Local).AddTicks(2955), "owner@gmail.com", false, false, null, "Owner", "OWNER@GMAIL.COM", "OWNER@GMAIL.COM", "AQAAAAEAACcQAAAAELQDiuppVO4mXwq0fp4OIN/7BhJJvpcmel9jadKNRpH6OK2YGx9ss9cy+A06bbm5vA==", null, false, "da247a56-2606-4565-80a9-87daf9800cbf", false, "https://drive.google.com/file/d/1oq-h_ATob2rQrB7X3Y_hzXflGzMBKWE5/view?usp=share_link", "owner@gmail.com", "https://us05web.zoom.us/j/82148537267?pwd=NjlYUWQzeFF6K1AxZEZRaklxbnF6QT09" },
                    { "b93130a7-a14b-46d0-b00d-f23536494dd2", 0, "Laguna", 23, "f5b8348d-1b2c-4e41-afe1-752013786f2e", new DateTime(2023, 4, 22, 15, 1, 38, 429, DateTimeKind.Local).AddTicks(8627), "client1@gmail.com", false, false, null, "Client One", "CLIENT1@GMAIL.COM", "CLIENT1@GMAIL.COM", "AQAAAAEAACcQAAAAEJGrrkFPIbQunbkXsZhhbqSGgAmTNE9uksb/0KqzYPViJY9yTUSsWC66zmRuBjiPvA==", null, false, "6aa3aef6-491c-4f64-ab5b-c5c03b8f8383", false, "https://drive.google.com/file/d/1psKFWk2mNDKwzGNAVhGYlH_ChmUF9mif/view?usp=share_link", "client1@gmail.com", null },
                    { "e1e3dc24-4d24-4468-b2db-017de922c7a6", 0, "Laguna", 23, "f959c19f-2005-4977-8f36-f128a89ce274", new DateTime(2023, 4, 22, 15, 1, 38, 431, DateTimeKind.Local).AddTicks(687), "client2@gmail.com", false, false, null, "Client Two", "CLIENT2@GMAIL.COM", "CLIENT2@GMAIL.COM", "AQAAAAEAACcQAAAAEBY9a7E/zgrbC155GIOQQ2kLyKwfNr9tL8pZsthAkr+S6Ft19lrAzlhDh4UPQCElfw==", null, false, "c41bd907-a5aa-4baa-bf7a-993134941fcd", false, "https://drive.google.com/file/d/1oaJ0CvIKImPmQyRI3DObShIhDukFRQg4/view?usp=share_link", "client2@gmail.com", null },
                    { "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae", 0, "Laguna", 23, "1f2f931a-f661-4f41-ac63-d230ab8e25c5", new DateTime(2023, 4, 22, 15, 1, 38, 428, DateTimeKind.Local).AddTicks(6392), "admin@gmail.com", false, false, null, "Admin", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEL8GONctr6y2LhpV7KwcV+CF0G7rqKfIvjuo5srgi6PlqK0jkG72xQbKK+pkOETO9g==", null, false, "737d0b4b-17eb-4b66-aa3f-bb3dd4cd09e8", false, "https://drive.google.com/file/d/1NDO0x8HSWPp7DJMrhhZlo8J62nTR7N0_/view?usp=share_link", "admin@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "PropertyCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A House.", "House" },
                    { 2, "A Condominium.", "Condominium" }
                });

            migrationBuilder.InsertData(
                table: "SaleorRentModel",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sale" },
                    { 2, "Rent" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "51d0771e-de96-4882-a01e-8f0b9949e90c", "62550723-3df6-4886-80c0-5ff90804ec07" },
                    { "5c965850-234a-4d90-9c24-024ebfac6f20", "b93130a7-a14b-46d0-b00d-f23536494dd2" },
                    { "5c965850-234a-4d90-9c24-024ebfac6f20", "e1e3dc24-4d24-4468-b2db-017de922c7a6" },
                    { "fb63abec-98f5-448e-8f56-302fafd16df4", "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae" }
                });

            migrationBuilder.InsertData(
                table: "EstateProperties",
                columns: new[] { "Id", "Address", "ApplicationUserId", "Description", "Name", "OwnerName", "Price", "PropertyCategoryId", "SaleOrRentModelId", "UrlImages" },
                values: new object[,]
                {
                    { 1, "GAMU - ROXAS HIGHWAY, DISTRICT II, GAMU", "62550723-3df6-4886-80c0-5ff90804ec07", "Gregoria Model (2-Storey Single Attached)\r\n\r\nUnit Price: Php 3,173,851.00\r\n\r\nNo. of Bedroom: 3\r\n\r\nNo. of Bathroom: 2\r\n\r\nLot Area: 110 sqm\r\n\r\nFloor Area: 72 sqm\r\n\r\n\r\n\r\nHEROES' LANE\r\n\r\nA mix-used horizontal development with a total of 668 units which is eyed to be the 1st EDGE Certified Green Project in Cagayan Valley and North Luzon.\r\n\r\n\r\n\r\nAmenities\r\n\r\nCommunity Function Hall\r\nReligious Chapel\r\nSolar Powered Units and Facilities\r\nBasketball and Tennis Courts\r\nHeroes Park\r\nChildren's Playground\r\nCommercial Lane\r\nGardens and Open Spaces\r\n\r\n\r\nLocation\r\n\r\nGamu - Roxas Highway, District 2, Gamu, Isabela, PH\r\n\r\n\r\n\r\nHLURB LTS No. CR # 021 / LTS # 038 / 039 / 040\r\n\r\nYear Built: 2022\r\n\r\nTurnover Date: 2024 - 2025\r\n\r\nTotal No. of Model Units: 7", "GREGORIA", "Owner", 3173851.0, 1, 1, "https://drive.google.com/file/d/1nDc-AJtVYm59dV8WQNpQQ3CgQ0lczCvC/" },
                    { 2, "OUANO AVE. COR. F.E. ZUELLIG AVE. SUBANGDAKU, MANDAUE", "62550723-3df6-4886-80c0-5ff90804ec07", "Mantawi Residences proudly calls Ouano Avenue, Mandaue City, Cebu its home, a prime spot where everything you need is within reach. With a multitude of infrastructure and development plans in the pipeline, this location is set to transform into a progressive district where you can reap the benefits of living at the center of everything. Take charge of your future with Mantawi Residences’ units equipped with upgraded smart home devices* so you can easily manage your home life without worry.\r\n\r\n", "Mantawi Residences ", "Owner", 37200000.0, 2, 2, "https://i.pinimg.com/originals/61/2b/ff/612bff8412e03dc3c84ea5aabe743d51.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ClientsId",
                table: "Appointments",
                column: "ClientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_EstatePropertyId",
                table: "Appointments",
                column: "EstatePropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_OwnerScheduleId",
                table: "Appointments",
                column: "OwnerScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_OwnersId",
                table: "Appointments",
                column: "OwnersId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EstateProperties_ApplicationUserId",
                table: "EstateProperties",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EstateProperties_PropertyCategoryId",
                table: "EstateProperties",
                column: "PropertyCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EstateProperties_SaleOrRentModelId",
                table: "EstateProperties",
                column: "SaleOrRentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EstatePropertyPropertyListViewModel_PropertyListViewsId",
                table: "EstatePropertyPropertyListViewModel",
                column: "PropertyListViewsId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerSchedules_OwnerId",
                table: "OwnerSchedules",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyCategoryPropertyListViewModel_PropertyListViewsId",
                table: "PropertyCategoryPropertyListViewModel",
                column: "PropertyListViewsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EstatePropertyPropertyListViewModel");

            migrationBuilder.DropTable(
                name: "PropertyCategoryPropertyListViewModel");

            migrationBuilder.DropTable(
                name: "OwnerSchedules");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "EstateProperties");

            migrationBuilder.DropTable(
                name: "PropertyListViewModel");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PropertyCategories");

            migrationBuilder.DropTable(
                name: "SaleorRentModel");
        }
    }
}
