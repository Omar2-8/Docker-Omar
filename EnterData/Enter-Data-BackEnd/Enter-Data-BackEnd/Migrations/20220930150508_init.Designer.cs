﻿// <auto-generated />
using Enter_Data_BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Enter_Data_BackEnd.Migrations
{
    [DbContext(typeof(NumbersDbContext))]
    [Migration("20220930150508_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Enter_Data_BackEnd.Models.Numbers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Number1")
                        .HasColumnType("int");

                    b.Property<int>("Number2")
                        .HasColumnType("int");

                    b.Property<int>("Number3")
                        .HasColumnType("int");

                    b.Property<int>("Number4")
                        .HasColumnType("int");

                    b.Property<int>("Number5")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Numbers");
                });
#pragma warning restore 612, 618
        }
    }
}
