﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShop.Data.Models;
using WebShop.Models;

namespace WebShop.Migrations
{
  [DbContext(typeof(WebShopContext))]
  [Migration("20190315113005_ProductUser")]
  partial class ProductUser
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
          .HasAnnotation("Relational:MaxIdentifierLength", 128)
          .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
          {
            b.Property<string>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<string>("ConcurrencyStamp")
                      .IsConcurrencyToken();

            b.Property<string>("Name")
                      .HasMaxLength(256);

            b.Property<string>("NormalizedName")
                      .HasMaxLength(256);

            b.HasKey("Id");

            b.HasIndex("NormalizedName")
                      .IsUnique()
                      .HasName("RoleNameIndex")
                      .HasFilter("[NormalizedName] IS NOT NULL");

            b.ToTable("AspNetRoles");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("ClaimType");

            b.Property<string>("ClaimValue");

            b.Property<string>("RoleId")
                      .IsRequired();

            b.HasKey("Id");

            b.HasIndex("RoleId");

            b.ToTable("AspNetRoleClaims");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("ClaimType");

            b.Property<string>("ClaimValue");

            b.Property<string>("UserId")
                      .IsRequired();

            b.HasKey("Id");

            b.HasIndex("UserId");

            b.ToTable("AspNetUserClaims");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
          {
            b.Property<string>("LoginProvider");

            b.Property<string>("ProviderKey");

            b.Property<string>("ProviderDisplayName");

            b.Property<string>("UserId")
                      .IsRequired();

            b.HasKey("LoginProvider", "ProviderKey");

            b.HasIndex("UserId");

            b.ToTable("AspNetUserLogins");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
          {
            b.Property<string>("UserId");

            b.Property<string>("RoleId");

            b.HasKey("UserId", "RoleId");

            b.HasIndex("RoleId");

            b.ToTable("AspNetUserRoles");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
          {
            b.Property<string>("UserId");

            b.Property<string>("LoginProvider");

            b.Property<string>("Name");

            b.Property<string>("Value");

            b.HasKey("UserId", "LoginProvider", "Name");

            b.ToTable("AspNetUserTokens");
          });

      modelBuilder.Entity("WebShop.Models.Order", b =>
          {
            b.Property<int>("OrderID")
                      .ValueGeneratedOnAdd()
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("UserId");

            b.HasKey("OrderID");

            b.HasIndex("UserId");

            b.ToTable("Order");
          });

      modelBuilder.Entity("WebShop.Models.OrderItem", b =>
          {
            b.Property<int>("OrderItemID")
                      .ValueGeneratedOnAdd()
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<int>("Amount");

            b.Property<int>("OrderID");

            b.Property<int>("ProductID");

            b.HasKey("OrderItemID");

            b.HasIndex("OrderID");

            b.HasIndex("ProductID");

            b.ToTable("OrderItem");
          });

      modelBuilder.Entity("WebShop.Models.Product", b =>
          {
            b.Property<int>("ID")
                      .ValueGeneratedOnAdd()
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("Description");

            b.Property<string>("ImageURL");

            b.Property<string>("Name")
                      .HasMaxLength(45);

            b.Property<decimal>("Price")
                      .HasColumnType("money");

            b.HasKey("ID");

            b.ToTable("Product");
          });

      modelBuilder.Entity("WebShop.Models.User", b =>
          {
            b.Property<string>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<int>("AccessFailedCount");

            b.Property<string>("ConcurrencyStamp")
                      .IsConcurrencyToken();

            b.Property<string>("Email")
                      .HasMaxLength(256);

            b.Property<bool>("EmailConfirmed");

            b.Property<string>("FullName")
                      .HasMaxLength(30);

            b.Property<bool>("LockoutEnabled");

            b.Property<DateTimeOffset?>("LockoutEnd");

            b.Property<string>("NormalizedEmail")
                      .HasMaxLength(256);

            b.Property<string>("NormalizedUserName")
                      .HasMaxLength(256);

            b.Property<string>("Password")
                      .HasMaxLength(25);

            b.Property<string>("PasswordHash");

            b.Property<string>("PhoneNumber");

            b.Property<bool>("PhoneNumberConfirmed");

            b.Property<string>("SecurityStamp");

            b.Property<bool>("TwoFactorEnabled");

            b.Property<string>("UserName")
                      .HasMaxLength(256);

            b.HasKey("Id");

            b.HasIndex("NormalizedEmail")
                      .HasName("EmailIndex");

            b.HasIndex("NormalizedUserName")
                      .IsUnique()
                      .HasName("UserNameIndex")
                      .HasFilter("[NormalizedUserName] IS NOT NULL");

            b.ToTable("AspNetUsers");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
          {
            b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                      .WithMany()
                      .HasForeignKey("RoleId")
                      .OnDelete(DeleteBehavior.Cascade);
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
          {
            b.HasOne("WebShop.Models.User")
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade);
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
          {
            b.HasOne("WebShop.Models.User")
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade);
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
          {
            b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                      .WithMany()
                      .HasForeignKey("RoleId")
                      .OnDelete(DeleteBehavior.Cascade);

            b.HasOne("WebShop.Models.User")
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade);
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
          {
            b.HasOne("WebShop.Models.User")
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade);
          });

      modelBuilder.Entity("WebShop.Models.Order", b =>
          {
            b.HasOne("WebShop.Models.User")
                      .WithMany("Orders")
                      .HasForeignKey("UserId");
          });

      modelBuilder.Entity("WebShop.Models.OrderItem", b =>
          {
            b.HasOne("WebShop.Models.Order", "Order")
                      .WithMany("OrderItems")
                      .HasForeignKey("OrderID")
                      .OnDelete(DeleteBehavior.Cascade);

            b.HasOne("WebShop.Models.Product", "Product")
                      .WithMany("OrderItems")
                      .HasForeignKey("ProductID")
                      .OnDelete(DeleteBehavior.Cascade);
          });
#pragma warning restore 612, 618
    }
  }
}
