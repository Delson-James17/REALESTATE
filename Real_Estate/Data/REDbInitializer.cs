using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Real_Estate.Models;
using System.Xml.Linq;

namespace Real_Estate.Data
{
    public static class REDbInitializer
    {
        public static void RolesSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "fb63abec-98f5-448e-8f56-302fafd16df4",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                },
                new IdentityRole
                {
                    Id = "5c965850-234a-4d90-9c24-024ebfac6f20",
                    Name = "Client",
                    NormalizedName = "CLIENT",
                },
                new IdentityRole
                {
                    Id = "51d0771e-de96-4882-a01e-8f0b9949e90c",
                    Name = "Owner",
                    NormalizedName = "OWNER",
                }
            );
        }

        public static void EstatePropertyCategorySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PropertyCategory>().HasData(
                new PropertyCategory
                {
                    Id = 1,
                    Name = "House",
                    Description = "A House.",
                },
                new PropertyCategory
                {
                    Id = 2,
                    Name = "Condominium",
                    Description = "A Condominium.",
                }
            );
        }

        public static void SaleOrRentSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SaleorRentModel>().HasData(
                new SaleorRentModel
                {
                    Id = 1,
                    Name = "Sale"
                },
                new SaleorRentModel
                {
                    Id = 2,
                    Name = "Rent"
                }
            );
        }

        public static void UserSeed(this ModelBuilder modelBuilder)
        {
            string defaultPassword = "P@ssword123";

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae",
                    Name = "Admin",
                    Age = 23,
                    Address = "Laguna",
                    DOB = DateTime.Now,
                    UrlImages = "https://drive.google.com/file/d/1NDO0x8HSWPp7DJMrhhZlo8J62nTR7N0_/view?usp=share_link",
                    UserName = "admin@gmail.com",
                    NormalizedUserName = "admin@gmail.com".ToUpper(),
                    NormalizedEmail = "admin@gmail.com".ToUpper(),
                    Email = "admin@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(null, defaultPassword)
                },
                new ApplicationUser
                {
                    Id = "b93130a7-a14b-46d0-b00d-f23536494dd2",
                    Name = "Client One",
                    Age = 23,
                    Address = "Laguna",
                    DOB = DateTime.Now,
                    UrlImages = "https://drive.google.com/file/d/1psKFWk2mNDKwzGNAVhGYlH_ChmUF9mif/view?usp=share_link",
                    UserName = "client1@gmail.com",
                    NormalizedUserName = "client1@gmail.com".ToUpper(),
                    NormalizedEmail = "client1@gmail.com".ToUpper(),
                    Email = "client1@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(null, defaultPassword)
                },
                new ApplicationUser
                {
                    Id = "e1e3dc24-4d24-4468-b2db-017de922c7a6",
                    Name = "Client Two",
                    Age = 23,
                    Address = "Laguna",
                    DOB = DateTime.Now,
                    UrlImages = "https://drive.google.com/file/d/1oaJ0CvIKImPmQyRI3DObShIhDukFRQg4/view?usp=share_link",
                    UserName = "client2@gmail.com",
                    NormalizedUserName = "client2@gmail.com".ToUpper(),
                    NormalizedEmail = "client2@gmail.com".ToUpper(),
                    Email = "client2@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(null, defaultPassword)
                },
                new ApplicationUser
                {
                    Id = "62550723-3df6-4886-80c0-5ff90804ec07",
                    Name = "Owner",
                    Age = 23,
                    Address = "Laguna",
                    DOB = DateTime.Now,
                    UrlImages = "https://drive.google.com/file/d/1oq-h_ATob2rQrB7X3Y_hzXflGzMBKWE5/view?usp=share_link",
                    UserName = "owner@gmail.com",
                    Zoomlink = "https://us05web.zoom.us/j/82148537267?pwd=NjlYUWQzeFF6K1AxZEZRaklxbnF6QT09",
                    NormalizedUserName = "owner@gmail.com".ToUpper(),
                    NormalizedEmail = "owner@gmail.com".ToUpper(),
                    Email = "owner@gmail.com",
                    PasswordHash = passwordHasher.HashPassword(null, defaultPassword)
                }
           );
        }

        public static void EstatePropertySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstateProperty>().HasData(
                new EstateProperty
                {
                    Id = 1,
                    Name = "GREGORIA",
                    Description = "Gregoria Model (2-Storey Single Attached)\r\n\r\nUnit Price: Php 3,173,851.00\r\n\r\nNo. of Bedroom: 3\r\n\r\nNo. of Bathroom: 2\r\n\r\nLot Area: 110 sqm\r\n\r\nFloor Area: 72 sqm\r\n\r\n\r\n\r\nHEROES' LANE\r\n\r\nA mix-used horizontal development with a total of 668 units which is eyed to be the 1st EDGE Certified Green Project in Cagayan Valley and North Luzon.\r\n\r\n\r\n\r\nAmenities\r\n\r\nCommunity Function Hall\r\nReligious Chapel\r\nSolar Powered Units and Facilities\r\nBasketball and Tennis Courts\r\nHeroes Park\r\nChildren's Playground\r\nCommercial Lane\r\nGardens and Open Spaces\r\n\r\n\r\nLocation\r\n\r\nGamu - Roxas Highway, District 2, Gamu, Isabela, PH\r\n\r\n\r\n\r\nHLURB LTS No. CR # 021 / LTS # 038 / 039 / 040\r\n\r\nYear Built: 2022\r\n\r\nTurnover Date: 2024 - 2025\r\n\r\nTotal No. of Model Units: 7",
                    Address = "GAMU - ROXAS HIGHWAY, DISTRICT II, GAMU",
                    UrlImages = "https://drive.google.com/file/d/1v_B1W2yHhFmGiewrZKs5i64WYeYcxXEX/view?usp=sharing",
                    Price = 3173851.00,
                    SaleOrRentModelId = 1,
                    PropertyCategoryId = 1,
                    ApplicationUserId = "62550723-3df6-4886-80c0-5ff90804ec07",
                    OwnerName = "Owner"
                },
                new EstateProperty
                {
                    Id = 2,
                    Name = "Mantawi Residences ",
                    Description = "Mantawi Residences proudly calls Ouano Avenue, Mandaue City, Cebu its home, a prime spot where everything you need is within reach. With a multitude of infrastructure and development plans in the pipeline, this location is set to transform into a progressive district where you can reap the benefits of living at the center of everything. Take charge of your future with Mantawi Residences’ units equipped with upgraded smart home devices* so you can easily manage your home life without worry.\r\n\r\n",
                    Address = "OUANO AVE. COR. F.E. ZUELLIG AVE. SUBANGDAKU, MANDAUE",
                    UrlImages = "https://i.pinimg.com/originals/61/2b/ff/612bff8412e03dc3c84ea5aabe743d51.jpg",
                    Price = 37200000,
                    SaleOrRentModelId = 2,
                    PropertyCategoryId = 2,
                    ApplicationUserId = "62550723-3df6-4886-80c0-5ff90804ec07",
                    OwnerName = "Owner"
                }
            );
        }

        public static void UserRoleSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "fb63abec-98f5-448e-8f56-302fafd16df4",
                    UserId = "f0fbf9f0-eb17-4c87-9c76-9de5451f74ae"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "5c965850-234a-4d90-9c24-024ebfac6f20",
                    UserId = "b93130a7-a14b-46d0-b00d-f23536494dd2"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "5c965850-234a-4d90-9c24-024ebfac6f20",
                    UserId = "e1e3dc24-4d24-4468-b2db-017de922c7a6"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "51d0771e-de96-4882-a01e-8f0b9949e90c",
                    UserId = "62550723-3df6-4886-80c0-5ff90804ec07"
                }
            );
        }
    }
}


