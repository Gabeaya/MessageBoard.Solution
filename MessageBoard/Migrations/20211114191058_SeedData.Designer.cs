﻿// <auto-generated />
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    [Migration("20211114191058_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MessageBoard.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("MessageDescription")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            Age = 17,
                            Date = "11-14-2021",
                            MessageDescription = "hey pablo ",
                            UserName = "Matilda"
                        },
                        new
                        {
                            MessageId = 2,
                            Age = 21,
                            Date = "06-31-1908",
                            MessageDescription = "oooooh you nasty",
                            UserName = "Rexie"
                        },
                        new
                        {
                            MessageId = 3,
                            Age = 35,
                            Date = "09-26-1998",
                            MessageDescription = "who are you sisi",
                            UserName = "Matilda"
                        },
                        new
                        {
                            MessageId = 4,
                            Age = 15,
                            Date = "02-10-1996",
                            MessageDescription = "My butt itches",
                            UserName = "Pip"
                        },
                        new
                        {
                            MessageId = 5,
                            Age = 22,
                            Date = "11-15-1999",
                            MessageDescription = "ya that sisi is one looker",
                            UserName = "Bartholomew"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
