﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "stars weekend trawis scott",
                            ImageUrl = "https://avatars.mds.yandex.net/i?id=69ebc3194bc39fbd68a48e92eb6e1e6caddfdcca-9236004-images-thumbs&n=13",
                            Price = 9.99m,
                            Title = "Galaxy"
                        },
                        new
                        {
                            Id = 2,
                            Description = "House house house man car",
                            ImageUrl = "https://avatars.mds.yandex.net/i?id=7be6729fc150193c06bf0c61840bff798ae2ab62-9152303-images-thumbs&n=13",
                            Price = 8.99m,
                            Title = "House"
                        },
                        new
                        {
                            Id = 3,
                            Description = "lorem ipsum",
                            ImageUrl = "https://avatars.mds.yandex.net/i?id=7fe5fc045d852fd08454e9bdda42ce1c41f21cc7-9035616-images-thumbs&n=13",
                            Price = 7.99m,
                            Title = "Marginal"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
