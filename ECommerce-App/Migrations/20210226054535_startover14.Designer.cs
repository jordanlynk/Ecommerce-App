﻿// <auto-generated />
using System;
using ECommerce_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerce_App.Migrations
{
    [DbContext(typeof(MjDbContext))]
    [Migration("20210226054535_startover14")]
    partial class startover14
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECommerce_App.Auth.Models.AuthUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ECommerce_App.Models.CartItem", b =>
                {
                    b.Property<int>("cartId")
                        .HasColumnType("int");

                    b.Property<int>("mealId")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cartId", "mealId");

                    b.HasIndex("mealId")
                        .IsUnique();

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("ECommerce_App.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("mealName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            id = 1,
                            name = "Vegan"
                        },
                        new
                        {
                            id = 2,
                            name = "Vegetarian"
                        },
                        new
                        {
                            id = 3,
                            name = "Pescatarian"
                        },
                        new
                        {
                            id = 4,
                            name = "Dessert"
                        },
                        new
                        {
                            id = 5,
                            name = "Comfort"
                        });
                });

            modelBuilder.Entity("ECommerce_App.Models.CreateCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CreateCart");
                });

            modelBuilder.Entity("ECommerce_App.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nutrition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meal");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ingredients = "beans, tomatoes, olive oil, tofu crumbles, spices, garlic",
                            name = "Vegan Chili",
                            nutrition = "healthy",
                            price = 12,
                            type = "vegan"
                        },
                        new
                        {
                            Id = 2,
                            ingredients = "tofu, olive oil, spices, garlic, green beans, potatoes",
                            name = "Pan Fried Tofu w/ veggies",
                            nutrition = "healthy",
                            price = 14,
                            type = "vegan"
                        },
                        new
                        {
                            Id = 3,
                            ingredients = "olives, tomato sauce, olive oil, tofu crumbles, spices, garlic, vegan cheese",
                            name = "Vegan Pizza",
                            nutrition = "healthy",
                            price = 15,
                            type = "vegan"
                        },
                        new
                        {
                            Id = 4,
                            ingredients = "Salmon filets, cherry tomatoes, olive oil, asparagus, spices, garlic",
                            name = "Salmon with veggies",
                            nutrition = "healthy",
                            price = 18,
                            type = "pescatarian"
                        },
                        new
                        {
                            Id = 5,
                            ingredients = "Shrimp, rice, olive oil, egg, spices, garlic, carrots, peas",
                            name = "Shrimp Fried Rice",
                            nutrition = "healthy",
                            price = 15,
                            type = "pescatarian"
                        },
                        new
                        {
                            Id = 6,
                            ingredients = "Cod, rice pilaf, olive oil, green beans, spices, garlic",
                            name = "Cod with rice pilaf and veggies",
                            nutrition = "healthy",
                            price = 17,
                            type = "pescatarian"
                        },
                        new
                        {
                            Id = 7,
                            ingredients = "espresso, ladyfingers, custard, cream, cocoa powder",
                            name = "Tiramisu",
                            nutrition = "not healthy",
                            price = 10,
                            type = "desert"
                        },
                        new
                        {
                            Id = 8,
                            ingredients = "chocolate, flour, sugar, eggs",
                            name = "Chocolate Cake",
                            nutrition = "not healthy",
                            price = 10,
                            type = "desert"
                        },
                        new
                        {
                            Id = 9,
                            ingredients = "cheese, tomatoes, Italian sausage, noodles, spices, garlic",
                            name = "Lasagna",
                            nutrition = "not healthy",
                            price = 20,
                            type = "comfort"
                        });
                });

            modelBuilder.Entity("ECommerce_App.Models.MealsByCategory", b =>
                {
                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("MealId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("MealsByCategory");
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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "administrator",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "editor",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "guest",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Guest",
                            NormalizedName = "GUEST"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "permissions",
                            ClaimValue = "read",
                            RoleId = "administrator"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "permissions",
                            ClaimValue = "create",
                            RoleId = "administrator"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "permissions",
                            ClaimValue = "update",
                            RoleId = "administrator"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "permissions",
                            ClaimValue = "delete",
                            RoleId = "administrator"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "permissions",
                            ClaimValue = "read",
                            RoleId = "editor"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "permissions",
                            ClaimValue = "create",
                            RoleId = "editor"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "permissions",
                            ClaimValue = "update",
                            RoleId = "editor"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "permissions",
                            ClaimValue = "read",
                            RoleId = "guest"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ECommerce_App.Models.CartItem", b =>
                {
                    b.HasOne("ECommerce_App.Models.CreateCart", "cart")
                        .WithMany("cartItem")
                        .HasForeignKey("cartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce_App.Models.Meal", "meal")
                        .WithOne("cartItem")
                        .HasForeignKey("ECommerce_App.Models.CartItem", "mealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cart");

                    b.Navigation("meal");
                });

            modelBuilder.Entity("ECommerce_App.Models.MealsByCategory", b =>
                {
                    b.HasOne("ECommerce_App.Models.Category", null)
                        .WithMany("ListOfMeals")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce_App.Models.Meal", "meal")
                        .WithMany()
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("meal");
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
                    b.HasOne("ECommerce_App.Auth.Models.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ECommerce_App.Auth.Models.AuthUser", null)
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

                    b.HasOne("ECommerce_App.Auth.Models.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ECommerce_App.Auth.Models.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerce_App.Models.Category", b =>
                {
                    b.Navigation("ListOfMeals");
                });

            modelBuilder.Entity("ECommerce_App.Models.CreateCart", b =>
                {
                    b.Navigation("cartItem");
                });

            modelBuilder.Entity("ECommerce_App.Models.Meal", b =>
                {
                    b.Navigation("cartItem");
                });
#pragma warning restore 612, 618
        }
    }
}