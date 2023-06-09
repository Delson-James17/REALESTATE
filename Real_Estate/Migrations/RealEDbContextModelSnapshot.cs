﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Real_Estate.Data;

#nullable disable

namespace Real_Estate.Migrations
{
    [DbContext(typeof(RealEDbContext))]
    partial class RealEDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EstatePropertyPropertyListViewModel", b =>
                {
                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyListViewsId")
                        .HasColumnType("int");

                    b.HasKey("PropertiesId", "PropertyListViewsId");

                    b.HasIndex("PropertyListViewsId");

                    b.ToTable("EstatePropertyPropertyListViewModel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "fb63abec-98f5-448e-8f56-302fafd16df4",
                            ConcurrencyStamp = "b203fd09-f457-45f2-ac72-cb75c30548f8",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "5c965850-234a-4d90-9c24-024ebfac6f20",
                            ConcurrencyStamp = "0f202727-4eb2-44cb-8eeb-2d88b86dadc8",
                            Name = "Client",
                            NormalizedName = "CLIENT"
                        },
                        new
                        {
                            Id = "51d0771e-de96-4882-a01e-8f0b9949e90c",
                            ConcurrencyStamp = "edf2f904-3381-4aef-944a-cde28fa37bec",
                            Name = "Owner",
                            NormalizedName = "OWNER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                            RoleId = "fb63abec-98f5-448e-8f56-302fafd16df4"
                        },
                        new
                        {
                            UserId = "b93130a7-a14b-46d0-b00d-f23536494dd2",
                            RoleId = "5c965850-234a-4d90-9c24-024ebfac6f20"
                        },
                        new
                        {
                            UserId = "e1e3dc24-4d24-4468-b2db-017de922c7a6",
                            RoleId = "5c965850-234a-4d90-9c24-024ebfac6f20"
                        },
                        new
                        {
                            UserId = "62550723-3df6-4886-80c0-5ff90804ec07",
                            RoleId = "51d0771e-de96-4882-a01e-8f0b9949e90c"
                        },
                        new
                        {
                            UserId = "72550723-3df6-4886-80c0-5ff90804ec07",
                            RoleId = "51d0771e-de96-4882-a01e-8f0b9949e90c"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PropertyCategoryPropertyListViewModel", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyListViewsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "PropertyListViewsId");

                    b.HasIndex("PropertyListViewsId");

                    b.ToTable("PropertyCategoryPropertyListViewModel");
                });

            modelBuilder.Entity("Real_Estate.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UrlImages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Zoomlink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                            AccessFailedCount = 0,
                            Address = "Laguna",
                            Age = 23,
                            ConcurrencyStamp = "0b5f8696-ebb5-4e7a-8bfd-2ac590b73dd2",
                            DOB = new DateTime(2023, 4, 26, 9, 34, 27, 327, DateTimeKind.Local).AddTicks(3779),
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Admin",
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKNRE5Rb5YwVzXVDpME2OPgmj9LXkkpdFeAgIjRTFRRakqTgHeLK6Mwgx4b7ggNANQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "29fe31f6-3dda-46ed-8e22-3436329bc98f",
                            TwoFactorEnabled = false,
                            UrlImages = "https://live.staticflickr.com/65535/52837724066_4d882431b9_w.jpg",
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "b93130a7-a14b-46d0-b00d-f23536494dd2",
                            AccessFailedCount = 0,
                            Address = "Laguna",
                            Age = 23,
                            ConcurrencyStamp = "0a0e570d-8a6d-48ee-a028-32fe5596764a",
                            DOB = new DateTime(2023, 4, 26, 9, 34, 27, 329, DateTimeKind.Local).AddTicks(3860),
                            Email = "client1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Client One",
                            NormalizedEmail = "CLIENT1@GMAIL.COM",
                            NormalizedUserName = "CLIENT1@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE5THkDj0uzR4nhZVkde234vXitRfbgIOcc/B0Q0WAjYo996syB+ReHV72kv9oNjDg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ab6a0114-0ab5-451d-9cdb-aa62d71361fe",
                            TwoFactorEnabled = false,
                            UrlImages = "https://live.staticflickr.com/65535/52837907994_47a8b89ac4_n.jpg",
                            UserName = "client1@gmail.com"
                        },
                        new
                        {
                            Id = "e1e3dc24-4d24-4468-b2db-017de922c7a6",
                            AccessFailedCount = 0,
                            Address = "Laguna",
                            Age = 23,
                            ConcurrencyStamp = "503a2dea-5954-4930-922c-69f2de23251e",
                            DOB = new DateTime(2023, 4, 26, 9, 34, 27, 331, DateTimeKind.Local).AddTicks(3377),
                            Email = "client2@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Client Two",
                            NormalizedEmail = "CLIENT2@GMAIL.COM",
                            NormalizedUserName = "CLIENT2@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGxPYnpYzX8u95GHRT6WpQ6XsUv8eFy0j3QThqOwMX3Hpz81zQMt/8b0vz02XSVpyA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d5bed309-79c2-45de-9af2-1c5c18a4113f",
                            TwoFactorEnabled = false,
                            UrlImages = "https://live.staticflickr.com/65535/52837908254_3c81ba99c7_n.jpg",
                            UserName = "client2@gmail.com"
                        },
                        new
                        {
                            Id = "62550723-3df6-4886-80c0-5ff90804ec07",
                            AccessFailedCount = 0,
                            Address = "Laguna",
                            Age = 23,
                            ConcurrencyStamp = "f3553ae8-7e8a-4096-82c0-dbb395f1eee7",
                            DOB = new DateTime(2023, 4, 26, 9, 34, 27, 333, DateTimeKind.Local).AddTicks(2734),
                            Email = "owne1r@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Owner one",
                            NormalizedEmail = "OWNER1@GMAIL.COM",
                            NormalizedUserName = "OWNER1@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMW5NoSw80PQgNyZNIoGpPtDoNmOGSPWQtf0c3/Cg/OW6dUxHfOzQw4qZoImrQPdPw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "01a24a4a-d262-4918-bb2a-04ffceb88ed6",
                            TwoFactorEnabled = false,
                            UrlImages = "https://live.staticflickr.com/65535/52837723986_d9afeb97e0_w.jpg",
                            UserName = "owner1@gmail.com",
                            Zoomlink = "https://us05web.zoom.us/j/82148537267?pwd=NjlYUWQzeFF6K1AxZEZRaklxbnF6QT09"
                        },
                        new
                        {
                            Id = "72550723-3df6-4886-80c0-5ff90804ec07",
                            AccessFailedCount = 0,
                            Address = "Laguna",
                            Age = 23,
                            ConcurrencyStamp = "a8ccb6ef-cba5-4bf8-965c-193c487165d0",
                            DOB = new DateTime(2023, 4, 26, 9, 34, 27, 335, DateTimeKind.Local).AddTicks(2381),
                            Email = "owner2@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Owner two",
                            NormalizedEmail = "OWNER2@GMAIL.COM",
                            NormalizedUserName = "OWNER2@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENAVBkd8H5SQY0qcls3cKBj7mSxzfIRU49jKC16Aomthvn2sIRRx2nnJNWk2h65pDQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8186badd-a826-4d94-8929-305775a915cb",
                            TwoFactorEnabled = false,
                            UrlImages = "https://live.staticflickr.com/65535/52837723986_d9afeb97e0_w.jpg",
                            UserName = "owner2@gmail.com",
                            Zoomlink = "https://live.staticflickr.com/65535/52837152367_3f166e4330_n.jpg"
                        });
                });

            modelBuilder.Entity("Real_Estate.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EstatePropertyId")
                        .HasColumnType("int");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("OwnersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ClientsId");

                    b.HasIndex("EstatePropertyId");

                    b.HasIndex("OwnerScheduleId");

                    b.HasIndex("OwnersId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Real_Estate.Models.EstateProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("PropertyCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("SaleOrRentModelId")
                        .HasColumnType("int");

                    b.Property<string>("UrlImages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("PropertyCategoryId");

                    b.HasIndex("SaleOrRentModelId");

                    b.ToTable("EstateProperties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "GAMU - ROXAS HIGHWAY, DISTRICT II, GAMU",
                            ApplicationUserId = "62550723-3df6-4886-80c0-5ff90804ec07",
                            Description = "Gregoria Model (2-Storey Single Attached)\r\n\r\nUnit Price: Php 3,173,851.00\r\n\r\nNo. of Bedroom: 3\r\n\r\nNo. of Bathroom: 2\r\n\r\nLot Area: 110 sqm\r\n\r\nFloor Area: 72 sqm\r\n\r\n\r\n\r\nHEROES' LANE\r\n\r\nA mix-used horizontal development with a total of 668 units which is eyed to be the 1st EDGE Certified Green Project in Cagayan Valley and North Luzon.\r\n\r\n\r\n\r\nAmenities\r\n\r\nCommunity Function Hall\r\nReligious Chapel\r\nSolar Powered Units and Facilities\r\nBasketball and Tennis Courts\r\nHeroes Park\r\nChildren's Playground\r\nCommercial Lane\r\nGardens and Open Spaces\r\n\r\n\r\nLocation\r\n\r\nGamu - Roxas Highway, District 2, Gamu, Isabela, PH\r\n\r\n\r\n\r\nHLURB LTS No. CR # 021 / LTS # 038 / 039 / 040\r\n\r\nYear Built: 2022\r\n\r\nTurnover Date: 2024 - 2025\r\n\r\nTotal No. of Model Units: 7",
                            Name = "GREGORIA",
                            OwnerName = "Owner One",
                            Price = 3173851.0,
                            PropertyCategoryId = 1,
                            SaleOrRentModelId = 1,
                            UrlImages = "https://live.staticflickr.com/65535/52838168898_681cda2416_z.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Address = "OUANO AVE. COR. F.E. ZUELLIG AVE. SUBANGDAKU, MANDAUE",
                            ApplicationUserId = "62550723-3df6-4886-80c0-5ff90804ec07",
                            Description = "Mantawi Residences proudly calls Ouano Avenue, Mandaue City, Cebu its home, a prime spot where everything you need is within reach. With a multitude of infrastructure and development plans in the pipeline, this location is set to transform into a progressive district where you can reap the benefits of living at the center of everything. Take charge of your future with Mantawi Residences’ units equipped with upgraded smart home devices* so you can easily manage your home life without worry.\r\n\r\n",
                            Name = "Mantawi Residences ",
                            OwnerName = "Owner One",
                            Price = 37200000.0,
                            PropertyCategoryId = 2,
                            SaleOrRentModelId = 2,
                            UrlImages = "https://live.staticflickr.com/65535/52846569259_000336d9bd.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Address = "OUANO AVE. COR. F.E. ZUELLIG AVE. SUBANGDAKU, MANDAUE",
                            ApplicationUserId = "62550723-3df6-4886-80c0-5ff90804ec07",
                            Description = "Mantawi Residences proudly calls Ouano Avenue, Mandaue City, Cebu its home, a prime spot where everything you need is within reach. With a multitude of infrastructure and development plans in the pipeline, this location is set to transform into a progressive district where you can reap the benefits of living at the center of everything. Take charge of your future with Mantawi Residences’ units equipped with upgraded smart home devices* so you can easily manage your home life without worry.\r\n\r\n",
                            Name = "Lynville ",
                            OwnerName = "Owner One",
                            Price = 37200000.0,
                            PropertyCategoryId = 1,
                            SaleOrRentModelId = 2,
                            UrlImages = "https://live.staticflickr.com/65535/52838168903_0504483e6e.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Address = "ADDRESS SAMPLE",
                            ApplicationUserId = "72550723-3df6-4886-80c0-5ff90804ec07",
                            Description = "COMMERCIAL DESCRIPTION",
                            Name = "COMMERCIAL",
                            OwnerName = "Owner Two",
                            Price = 2000.0,
                            PropertyCategoryId = 3,
                            SaleOrRentModelId = 2,
                            UrlImages = "https://live.staticflickr.com/65535/52838125720_0def4691c2.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Address = "OUANO AVE. COR. F.E. ZUELLIG AVE. SUBANGDAKU, MANDAUE",
                            ApplicationUserId = "72550723-3df6-4886-80c0-5ff90804ec07",
                            Description = "Pioneer Woodlands Condo",
                            Name = "Pioneer Woodlands ",
                            OwnerName = "Owner Two",
                            Price = 37200000.0,
                            PropertyCategoryId = 1,
                            SaleOrRentModelId = 2,
                            UrlImages = "https://live.staticflickr.com/65535/52838168918_e35af8184f_w.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Address = "OUANO AVE. COR. F.E. ZUELLIG AVE. SUBANGDAKU, MANDAUE",
                            ApplicationUserId = "72550723-3df6-4886-80c0-5ff90804ec07",
                            Description = "THIS IS COMMERCIAL 2",
                            Name = "COMMERCIAL 2",
                            OwnerName = "Owner Two",
                            Price = 37200000.0,
                            PropertyCategoryId = 3,
                            SaleOrRentModelId = 1,
                            UrlImages = "https://live.staticflickr.com/65535/52838125630_a96d82c343_w.jpg"
                        });
                });

            modelBuilder.Entity("Real_Estate.Models.OwnerSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("endTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("startTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("OwnerSchedules");
                });

            modelBuilder.Entity("Real_Estate.Models.PropertyCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PropertyCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A House.",
                            Name = "House"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A Condominium.",
                            Name = "Condominium"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A Commercial.",
                            Name = "Commercial"
                        });
                });

            modelBuilder.Entity("Real_Estate.Models.PropertyListViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("EstateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PropertyListViewModel");
                });

            modelBuilder.Entity("Real_Estate.Models.SaleorRentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SaleorRentModel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sale"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rent"
                        });
                });

            modelBuilder.Entity("EstatePropertyPropertyListViewModel", b =>
                {
                    b.HasOne("Real_Estate.Models.EstateProperty", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Real_Estate.Models.PropertyListViewModel", null)
                        .WithMany()
                        .HasForeignKey("PropertyListViewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Real_Estate.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Real_Estate.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Real_Estate.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Real_Estate.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PropertyCategoryPropertyListViewModel", b =>
                {
                    b.HasOne("Real_Estate.Models.PropertyCategory", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Real_Estate.Models.PropertyListViewModel", null)
                        .WithMany()
                        .HasForeignKey("PropertyListViewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Real_Estate.Models.Appointment", b =>
                {
                    b.HasOne("Real_Estate.Models.ApplicationUser", "Clients")
                        .WithMany()
                        .HasForeignKey("ClientsId");

                    b.HasOne("Real_Estate.Models.EstateProperty", "EstateProperty")
                        .WithMany()
                        .HasForeignKey("EstatePropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Real_Estate.Models.OwnerSchedule", "OwnerSchedules")
                        .WithMany()
                        .HasForeignKey("OwnerScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Real_Estate.Models.ApplicationUser", "Owners")
                        .WithMany()
                        .HasForeignKey("OwnersId");

                    b.Navigation("Clients");

                    b.Navigation("EstateProperty");

                    b.Navigation("OwnerSchedules");

                    b.Navigation("Owners");
                });

            modelBuilder.Entity("Real_Estate.Models.EstateProperty", b =>
                {
                    b.HasOne("Real_Estate.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Properties")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Real_Estate.Models.PropertyCategory", "PropertyCategory")
                        .WithMany("EstateProperties")
                        .HasForeignKey("PropertyCategoryId");

                    b.HasOne("Real_Estate.Models.SaleorRentModel", "SaleOrRentModel")
                        .WithMany("EstateProperties")
                        .HasForeignKey("SaleOrRentModelId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("PropertyCategory");

                    b.Navigation("SaleOrRentModel");
                });

            modelBuilder.Entity("Real_Estate.Models.OwnerSchedule", b =>
                {
                    b.HasOne("Real_Estate.Models.ApplicationUser", "Owner")
                        .WithMany("OwnerScedules")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Real_Estate.Models.ApplicationUser", b =>
                {
                    b.Navigation("OwnerScedules");

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Real_Estate.Models.PropertyCategory", b =>
                {
                    b.Navigation("EstateProperties");
                });

            modelBuilder.Entity("Real_Estate.Models.SaleorRentModel", b =>
                {
                    b.Navigation("EstateProperties");
                });
#pragma warning restore 612, 618
        }
    }
}
