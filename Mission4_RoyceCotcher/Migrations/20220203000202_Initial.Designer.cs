﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4_RoyceCotcher.Models;

namespace Mission4_RoyceCotcher.Migrations
{
    [DbContext(typeof(MovieSubmitContext))]
    [Migration("20220203000202_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4_RoyceCotcher.Models.MovieSubmit", b =>
                {
                    b.Property<uint>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1u,
                            Category = "Adventure",
                            Director = "Ben Stiller",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Secret Life of Walter Mitty, The",
                            Year = (ushort)2013
                        },
                        new
                        {
                            MovieId = 2u,
                            Category = "Animated",
                            Director = "Ron Clements, John Musker",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "G",
                            Title = "Princess and the Frog, The",
                            Year = (ushort)2009
                        },
                        new
                        {
                            MovieId = 3u,
                            Category = "War Drama",
                            Director = "Phil Alden Robinson, Richard Loncraine, Mikael Salomon, David Nutter, Tom Hanks, David Leland, David Frankel, Tony To",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "TV-MA",
                            Title = "Band of Brothers",
                            Year = (ushort)2001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}