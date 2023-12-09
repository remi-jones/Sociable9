﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sociable9.Data;

#nullable disable

namespace Sociable9.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231209161240_updateDBName")]
    partial class updateDBName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Sociable9.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Name = "Family"
                        },
                        new
                        {
                            CategoryID = 2,
                            Name = "Friend"
                        },
                        new
                        {
                            CategoryID = 3,
                            Name = "Work"
                        },
                        new
                        {
                            CategoryID = 4,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("Sociable9.Models.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Contact");

                    b.HasData(
                        new
                        {
                            ContactID = 1,
                            Address = "1234 Street",
                            CategoryID = 1,
                            CreationDate = new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1747),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "123-456-7890",
                            PostalCode = "12345",
                            Province = "Province",
                            Town = "Townsville",
                            Username = "11contacts"
                        },
                        new
                        {
                            ContactID = 2,
                            Address = "5678 Avenue",
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1810),
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            PhoneNumber = "098-765-4321",
                            PostalCode = "54321",
                            Province = "Province",
                            Town = "Citytown",
                            Username = "11contacts"
                        },
                        new
                        {
                            ContactID = 3,
                            Address = "5678 Avenue",
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1814),
                            Email = "jenny.smith@example.com",
                            FirstName = "Jenny",
                            LastName = "Smith",
                            PhoneNumber = "098-765-4321",
                            PostalCode = "54321",
                            Province = "Province",
                            Town = "Citytown",
                            Username = "11contacts"
                        },
                        new
                        {
                            ContactID = 4,
                            Address = "5678 Avenue",
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1817),
                            Email = "jenny.smith@example.com",
                            FirstName = "Jenny",
                            LastName = "Smith",
                            PhoneNumber = "098-765-4321",
                            PostalCode = "54321",
                            Province = "Province",
                            Town = "Citytown",
                            Username = "11contacts"
                        },
                        new
                        {
                            ContactID = 5,
                            Address = "5678 Avenue",
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1820),
                            Email = "jenny.smith@example.com",
                            FirstName = "Jenny",
                            LastName = "Smith",
                            PhoneNumber = "098-765-4321",
                            PostalCode = "54321",
                            Province = "Province",
                            Town = "Citytown",
                            Username = "11contacts"
                        },
                        new
                        {
                            ContactID = 6,
                            Address = "5678 Avenue",
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1823),
                            Email = "jenny.smith@example.com",
                            FirstName = "Jenny",
                            LastName = "Smith",
                            PhoneNumber = "098-765-4321",
                            PostalCode = "54321",
                            Province = "Province",
                            Town = "Citytown",
                            Username = "11contacts"
                        },
                        new
                        {
                            ContactID = 7,
                            Address = "5678 Avenue",
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1826),
                            Email = "jenny.smith@example.com",
                            FirstName = "Jenny",
                            LastName = "Smith",
                            PhoneNumber = "098-765-4321",
                            PostalCode = "54321",
                            Province = "Province",
                            Town = "Citytown",
                            Username = "11contacts"
                        },
                        new
                        {
                            ContactID = 8,
                            Address = "5678 Avenue",
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1830),
                            Email = "jenny.smith@example.com",
                            FirstName = "Jenny",
                            LastName = "Smith",
                            PhoneNumber = "098-765-4321",
                            PostalCode = "54321",
                            Province = "Province",
                            Town = "Citytown",
                            Username = "11contacts"
                        },
                        new
                        {
                            ContactID = 9,
                            Address = "5678 Avenue",
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1833),
                            Email = "jenny.smith@example.com",
                            FirstName = "Jenny",
                            LastName = "Smith",
                            PhoneNumber = "098-765-4321",
                            PostalCode = "54321",
                            Province = "Province",
                            Town = "Citytown",
                            Username = "11contacts"
                        },
                        new
                        {
                            ContactID = 10,
                            Address = "5678 Avenue",
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1836),
                            Email = "jenny.smith@example.com",
                            FirstName = "Jenny",
                            LastName = "Smith",
                            PhoneNumber = "098-765-4321",
                            PostalCode = "54321",
                            Province = "Province",
                            Town = "Citytown",
                            Username = "11contacts"
                        },
                        new
                        {
                            ContactID = 11,
                            Address = "5678 Avenue",
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1839),
                            Email = "jenny.smith@example.com",
                            FirstName = "Jenny",
                            LastName = "Smith",
                            PhoneNumber = "098-765-4321",
                            PostalCode = "54321",
                            Province = "Province",
                            Town = "Citytown",
                            Username = "11contacts"
                        },
                        new
                        {
                            ContactID = 12,
                            Address = "5678 Avenue",
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1842),
                            Email = "jenny.smith@example.com",
                            FirstName = "Jenny",
                            LastName = "Smith",
                            PhoneNumber = "098-765-4321",
                            PostalCode = "54321",
                            Province = "Province",
                            Town = "Citytown",
                            Username = "1contact"
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

            modelBuilder.Entity("Sociable9.Models.Contact", b =>
                {
                    b.HasOne("Sociable9.Models.Category", "Category")
                        .WithMany("Contacts")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Sociable9.Models.Category", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
