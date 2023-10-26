﻿// <auto-generated />
using System;
using E_Commerce_Platform.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace E_Commerce_Platform.Migrations
{
    [DbContext(typeof(ECommerceDBContext))]
    [Migration("20231026103939_Seeding-description-data-to-categories-table")]
    partial class Seedingdescriptiondatatocategoriestable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = -7,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "<<Phones, tablets, and gadgets>> refer to a diverse range of modern electronic devices. This category includes smartphones for communication, tablets for work and play, and various gadgets to enhance your digital life. Explore the latest in technology, connectivity, and convenience in this dynamic category.",
                            Name = "Phones, tablets and gadgets",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -6,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "<<Televisions, audio-video, and photography>> encompass the world of visual and auditory experiences. Within this category, you can find cutting-edge TVs for immersive viewing, audio equipment to elevate your sound, and photography gear to capture life's memorable moments. Dive into a world of stunning sights and sounds with these products.",
                            Name = "Televisions, audio-video and photography",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -5,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "<<Laptops and computer equipment>> provide the tools you need to stay connected and productive in the digital age. This category offers a range of laptops and essential computer peripherals and accessories. Whether you need a powerful laptop for work or play or require computer equipment to enhance your setup, you'll find it here.",
                            Name = "Laptops and computer equipment",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -4,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Air conditioners and other climate equipment includes a variety of devices designed to control the temperature and climate of your living or working space. This category offers a selection of air conditioners, heaters, fans, and other climate control equipment to help you create a comfortable environment in any season.",
                            Name = "Air conditioners and other climate equipment",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -3,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "<<Major home appliances>> refers to large, essential electrical machines commonly used in households to perform various tasks. These appliances are typically permanent fixtures and include items like refrigerators, washing machines, dryers, ovens, stoves, dishwashers, and more. They play a crucial role in modern living by simplifying daily tasks and enhancing overall household efficiency.",
                            Name = "Major Home Appliances",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -2,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "<<Small appliances>> are compact and portable electrical devices designed to perform specific tasks in households. These appliances are typically used for various kitchen, cleaning, and personal care purposes. Examples of small appliances include toasters, blenders, coffee makers, electric kettles, microwave ovens, vacuum cleaners, irons, hair dryers, and more. Small appliances are known for their convenience, as they make daily chores and routines more manageable.",
                            Name = "Small Appliances",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -1,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Game consoles and accessories refer to the hardware and peripherals used for playing video games. Game consoles are specialized electronic devices designed primarily for gaming and typically come with built-in gaming capabilities, controllers, and other features. Accessories, on the other hand, are add-ons or enhancements that can improve the gaming experience. Common game consoles include products from companies like Sony (PlayStation), Microsoft (Xbox), and Nintendo, while accessories can encompass items like extra controllers, virtual reality headsets, gaming keyboards and mice, steering wheels, and more. Gamers often invest in these accessories to enhance their gameplay and overall enjoyment of video games.",
                            Name = "Game consoles and accessories",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.CategoryProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryProducts");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = -5,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Black",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -4,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Gray",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -3,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Blue",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -2,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "White",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -1,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Red",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsRead")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ReadDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string[]>("Recipients")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhysicalImageName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.ProductColor", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("ColorId")
                        .HasColumnType("integer");

                    b.HasKey("ProductId", "ColorId");

                    b.HasIndex("ColorId");

                    b.ToTable("ProductColors");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.ProductSize", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("SizeId")
                        .HasColumnType("integer");

                    b.HasKey("ProductId", "SizeId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductSizes");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = -7,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "XXS",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -6,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "XS",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -5,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "S",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -4,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "M",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -3,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "L",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -2,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "XL",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -1,
                            CreatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "XXL",
                            UpdatedAt = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AccountBalance")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateofBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmailPassword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte>("Gender")
                        .HasColumnType("smallint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsFrozen")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("MembershipPassword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PIN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhysicalImageName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.CategoryProduct", b =>
                {
                    b.HasOne("E_Commerce_Platform.DataBase.Models.Category", "Category")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce_Platform.DataBase.Models.Product", "Product")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.Email", b =>
                {
                    b.HasOne("E_Commerce_Platform.DataBase.Models.User", "User")
                        .WithMany("Emails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.ProductColor", b =>
                {
                    b.HasOne("E_Commerce_Platform.DataBase.Models.Color", "Color")
                        .WithMany("ProductColors")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce_Platform.DataBase.Models.Product", "Product")
                        .WithMany("ProductColors")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.ProductSize", b =>
                {
                    b.HasOne("E_Commerce_Platform.DataBase.Models.Product", "Product")
                        .WithMany("ProductSizes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce_Platform.DataBase.Models.Size", "Size")
                        .WithMany("ProductSizes")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.Category", b =>
                {
                    b.Navigation("CategoryProducts");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.Color", b =>
                {
                    b.Navigation("ProductColors");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.Product", b =>
                {
                    b.Navigation("CategoryProducts");

                    b.Navigation("ProductColors");

                    b.Navigation("ProductSizes");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.Size", b =>
                {
                    b.Navigation("ProductSizes");
                });

            modelBuilder.Entity("E_Commerce_Platform.DataBase.Models.User", b =>
                {
                    b.Navigation("Emails");
                });
#pragma warning restore 612, 618
        }
    }
}
