﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UgghhMagazine.Data;

#nullable disable

namespace ugghhMagazine.Migrations
{
    [DbContext(typeof(UgghhMagazineDbContext))]
    [Migration("20240201203638_bool")]
    partial class @bool
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                            ConcurrencyStamp = "13489061-6201-41aa-a4d5-9247008660b8",
                            Name = "Admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f08c4c5e-ca7f-4058-b54f-01db7c56d8b5",
                            Email = "admina@strator.comx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEIV3nUU+bctcE4aXEnO0Rs4uPkKc3g1C7wU657y5XAtJYDjjEBAs3tfbQrv2NA1ZKw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2ee6eb50-f4f7-4370-afe3-eb127060fe0e",
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("UgghhMagazine.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Poetry"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Short Story"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Opinion"
                        });
                });

            modelBuilder.Entity("UgghhMagazine.Models.Likes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PostId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserProfileId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("UgghhMagazine.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int?>("UserProfileId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("IdentityUserId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Post");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Author A",
                            CategoryId = 1,
                            Content = "Exciting tech news!",
                            Date = new DateTime(2024, 1, 27, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5680),
                            Title = "A Poem is Poetry",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 2,
                            Author = "Author B",
                            CategoryId = 2,
                            Content = "Latest fashion trends!",
                            Date = new DateTime(2024, 1, 22, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5730),
                            Title = "A Short Story is Hard to Write",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 3,
                            Author = "Author C",
                            CategoryId = 3,
                            Content = "Amazing travel adventures!",
                            Date = new DateTime(2024, 1, 17, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5730),
                            Title = "Travel Boom Leads to Gentrification",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 4,
                            Author = "Pizza Lover",
                            CategoryId = 1,
                            Content = "Exploring the pizza world!",
                            Date = new DateTime(2024, 1, 25, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5740),
                            Title = "The Quest for the Perfect Pizza",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 5,
                            Author = "Tech Dancer",
                            CategoryId = 2,
                            Content = "Innovative dance moves with robots!",
                            Date = new DateTime(2024, 1, 20, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5740),
                            Title = "Dancing with Robots",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 6,
                            Author = "VR Artist",
                            CategoryId = 3,
                            Content = "Immersive art experiences!",
                            Date = new DateTime(2024, 1, 12, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5740),
                            Title = "Surreal Paintings in Virtual Reality",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 7,
                            Author = "Aqua Weaver",
                            CategoryId = 1,
                            Content = "Unique aquatic crafting!",
                            Date = new DateTime(2024, 1, 24, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5740),
                            Title = "Adventures in Underwater Basket Weaving",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 8,
                            Author = "Fort Architect",
                            CategoryId = 2,
                            Content = "Building the ultimate pillow fortress!",
                            Date = new DateTime(2024, 1, 14, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5750),
                            Title = "Epic Pillow Fort Construction",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 9,
                            Author = "Sock Scientist",
                            CategoryId = 3,
                            Content = "Unraveling the mysteries of sock pairs!",
                            Date = new DateTime(2024, 1, 18, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5750),
                            Title = "The Science of Sock Matching",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 10,
                            Author = "Budget Astronaut",
                            CategoryId = 1,
                            Content = "Exploring the cosmos without breaking the bank!",
                            Date = new DateTime(2024, 1, 21, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5750),
                            Title = "Space Travel on a Budget",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 11,
                            Author = "Chef Chronos",
                            CategoryId = 2,
                            Content = "Cooking across different eras!",
                            Date = new DateTime(2024, 1, 15, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5750),
                            Title = "Time-Traveling Cookbook Adventures",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 12,
                            Author = "Ink Detective",
                            CategoryId = 3,
                            Content = "Unveiling hidden messages!",
                            Date = new DateTime(2024, 1, 23, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5760),
                            Title = "Secrets of Invisible Ink",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 13,
                            Author = "Paper Pilot",
                            CategoryId = 1,
                            Content = "Achieving new heights with paper airplanes!",
                            Date = new DateTime(2024, 1, 19, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5760),
                            Title = "World Record for Paper Airplane Flight",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 14,
                            Author = "Zero-G Juggler",
                            CategoryId = 2,
                            Content = "Juggling feats in outer space!",
                            Date = new DateTime(2024, 1, 16, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5760),
                            Title = "Extreme Juggling in Zero Gravity",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 15,
                            Author = "Entomophagist",
                            CategoryId = 3,
                            Content = "Culinary adventures with insects!",
                            Date = new DateTime(2024, 1, 13, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5760),
                            Title = "Gourmet Insect Tasting",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 16,
                            Author = "Avian Adrenaline Junkie",
                            CategoryId = 1,
                            Content = "Soaring through the skies with birds!",
                            Date = new DateTime(2024, 1, 11, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5770),
                            Title = "Skydiving with Feathered Friends",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 17,
                            Author = "Extraterrestrial Dancer",
                            CategoryId = 2,
                            Content = "Interstellar dance language!",
                            Date = new DateTime(2024, 1, 26, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5770),
                            Title = "Alien Communication through Dance",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 18,
                            Author = "Quantum Baker",
                            CategoryId = 3,
                            Content = "Baking with a quantum twist!",
                            Date = new DateTime(2024, 1, 10, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5770),
                            Title = "Mysteries of Quantum Baking",
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 19,
                            Author = "Unicorn Enthusiast",
                            CategoryId = 1,
                            Content = "Seek",
                            Date = new DateTime(2024, 1, 9, 15, 36, 37, 664, DateTimeKind.Local).AddTicks(5770),
                            Title = "Unicorn Tracking Expeditions",
                            UserProfileId = 1
                        });
                });

            modelBuilder.Entity("UgghhMagazine.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<List<string>>("Roles")
                        .HasColumnType("text[]");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "101 Main Street",
                            FirstName = "Admina",
                            IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            IsAdmin = false,
                            LastName = "Strator"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UgghhMagazine.Models.Likes", b =>
                {
                    b.HasOne("UgghhMagazine.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UgghhMagazine.Models.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId");

                    b.Navigation("Post");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("UgghhMagazine.Models.Post", b =>
                {
                    b.HasOne("UgghhMagazine.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.HasOne("UgghhMagazine.Models.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId");

                    b.Navigation("Category");

                    b.Navigation("IdentityUser");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("UgghhMagazine.Models.UserProfile", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.Navigation("IdentityUser");
                });
#pragma warning restore 612, 618
        }
    }
}
