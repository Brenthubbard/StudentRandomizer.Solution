// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentRandomizer.Models;

namespace StudentRandomizer.Migrations
{
    [DbContext(typeof(StudentRandomizerContext))]
    [Migration("20210616165307_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("StudentRandomizer.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1
                        },
                        new
                        {
                            GroupId = 2
                        },
                        new
                        {
                            GroupId = 3
                        },
                        new
                        {
                            GroupId = 4
                        },
                        new
                        {
                            GroupId = 5
                        });
                });

            modelBuilder.Entity("StudentRandomizer.Models.GroupStudent", b =>
                {
                    b.Property<int>("GroupStudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("GroupStudentId");

                    b.ToTable("GroupStudent");
                });

            modelBuilder.Entity("StudentRandomizer.Models.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MatchScore")
                        .HasColumnType("int");

                    b.HasKey("MatchId");

                    b.ToTable("Matches");

                    b.HasData(
                        new
                        {
                            MatchId = 1,
                            MatchScore = 0
                        },
                        new
                        {
                            MatchId = 2,
                            MatchScore = 0
                        },
                        new
                        {
                            MatchId = 3,
                            MatchScore = 0
                        },
                        new
                        {
                            MatchId = 4,
                            MatchScore = 0
                        },
                        new
                        {
                            MatchId = 5,
                            MatchScore = 0
                        });
                });

            modelBuilder.Entity("StudentRandomizer.Models.MatchStudent", b =>
                {
                    b.Property<int>("MatchStudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("MatchStudentId");

                    b.ToTable("MatchStudent");
                });

            modelBuilder.Entity("StudentRandomizer.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Name = "Ahmed Ghouzlane"
                        },
                        new
                        {
                            StudentId = 2,
                            Name = "Brandon Magofna"
                        },
                        new
                        {
                            StudentId = 3,
                            Name = "Brent Hubbard"
                        },
                        new
                        {
                            StudentId = 4,
                            Name = "Carlos Mendez"
                        },
                        new
                        {
                            StudentId = 5,
                            Name = "Cassandra Copp"
                        },
                        new
                        {
                            StudentId = 6,
                            Name = "Cristina Plesa"
                        },
                        new
                        {
                            StudentId = 7,
                            Name = "Giancarlo Vigneri"
                        },
                        new
                        {
                            StudentId = 8,
                            Name = "Isaac Moreno"
                        },
                        new
                        {
                            StudentId = 9,
                            Name = "James Wyn"
                        },
                        new
                        {
                            StudentId = 10,
                            Name = "Jamie Knutsen"
                        },
                        new
                        {
                            StudentId = 11,
                            Name = "Jeremy Banka"
                        },
                        new
                        {
                            StudentId = 12,
                            Name = "Jesse White"
                        },
                        new
                        {
                            StudentId = 13,
                            Name = "John Edmondson"
                        },
                        new
                        {
                            StudentId = 14,
                            Name = "Jonathan Stull"
                        },
                        new
                        {
                            StudentId = 15,
                            Name = "Marney Mallory"
                        },
                        new
                        {
                            StudentId = 16,
                            Name = "Michael Burton"
                        },
                        new
                        {
                            StudentId = 17,
                            Name = "Min Chang"
                        },
                        new
                        {
                            StudentId = 18,
                            Name = "Nicholas Reeder"
                        },
                        new
                        {
                            StudentId = 19,
                            Name = "Patrick Lee"
                        },
                        new
                        {
                            StudentId = 20,
                            Name = "Ryan Walker"
                        },
                        new
                        {
                            StudentId = 21,
                            Name = "Sammai Gutierrez"
                        },
                        new
                        {
                            StudentId = 22,
                            Name = "Seth Medeiros"
                        },
                        new
                        {
                            StudentId = 23,
                            Name = "Thomas Friedrichs"
                        },
                        new
                        {
                            StudentId = 24,
                            Name = "Thomas Russell"
                        },
                        new
                        {
                            StudentId = 25,
                            Name = "Tiffany Greathead"
                        },
                        new
                        {
                            StudentId = 26,
                            Name = "Tom Geraghty"
                        },
                        new
                        {
                            StudentId = 27,
                            Name = "Vanessa Su"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
