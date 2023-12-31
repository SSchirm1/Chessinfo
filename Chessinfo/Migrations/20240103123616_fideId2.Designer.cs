﻿// <auto-generated />
using System;
using Chessinfo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Chessinfo.Migrations
{
    [DbContext(typeof(ChessinfoContext))]
    [Migration("20240103123616_fideId2")]
    partial class fideId2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Chessinfo.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Chessinfo.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BlackId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WhiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlackId");

                    b.HasIndex("WhiteId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("Chessinfo.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("FideId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMale")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TitleId")
                        .HasColumnType("int");

                    b.Property<float?>("blitzRating")
                        .HasColumnType("real");

                    b.Property<float?>("classicalRating")
                        .HasColumnType("real");

                    b.Property<int?>("nationalRank")
                        .HasColumnType("int");

                    b.Property<float?>("rapidRating")
                        .HasColumnType("real");

                    b.Property<int?>("worldRank")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("TitleId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Chessinfo.Models.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Title");
                });

            modelBuilder.Entity("Chessinfo.Models.Game", b =>
                {
                    b.HasOne("Chessinfo.Models.Player", "Black")
                        .WithMany()
                        .HasForeignKey("BlackId");

                    b.HasOne("Chessinfo.Models.Player", "White")
                        .WithMany()
                        .HasForeignKey("WhiteId");

                    b.Navigation("Black");

                    b.Navigation("White");
                });

            modelBuilder.Entity("Chessinfo.Models.Player", b =>
                {
                    b.HasOne("Chessinfo.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("Chessinfo.Models.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId");

                    b.Navigation("Country");

                    b.Navigation("Title");
                });
#pragma warning restore 612, 618
        }
    }
}
