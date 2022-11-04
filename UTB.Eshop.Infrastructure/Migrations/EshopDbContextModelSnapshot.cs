﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UTB.Eshop.Infrastructure.Database;

namespace UTB.Eshop.Infrastructure.Migrations
{
    [DbContext(typeof(EshopDbContext))]
    partial class EshopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("UTB.Eshop.Domain.Entities.CarouselItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageAlt")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageSrc")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("CarouselItems");
                });
#pragma warning restore 612, 618
        }
    }
}
