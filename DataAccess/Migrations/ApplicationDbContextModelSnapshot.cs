﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Entities.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Chipped")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<int>("EscapeAttempts")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Neutered")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Sex")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("SpeciesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("WeightInKilos")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("SpeciesId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Chipped = 0,
                            CreatedBy = "Anna Bergsson",
                            DateRegistered = new DateTime(2023, 7, 27, 10, 48, 39, 857, DateTimeKind.Utc).AddTicks(5735),
                            EscapeAttempts = 0,
                            Name = "Lad",
                            Neutered = 0,
                            OwnerId = 1,
                            Sex = 1,
                            SpeciesId = 2,
                            WeightInKilos = 3m
                        },
                        new
                        {
                            Id = 2,
                            Chipped = 1,
                            CreatedBy = "Anna Bergsson",
                            DateOfBirth = new DateTime(2023, 7, 27, 12, 48, 39, 857, DateTimeKind.Local).AddTicks(9227),
                            DateRegistered = new DateTime(2023, 7, 27, 10, 48, 39, 857, DateTimeKind.Utc).AddTicks(9206),
                            EscapeAttempts = 0,
                            Name = "Inka",
                            Neutered = 1,
                            OwnerId = 1,
                            Sex = 2,
                            SpeciesId = 2,
                            WeightInKilos = 2m
                        },
                        new
                        {
                            Id = 3,
                            Chipped = 0,
                            CreatedBy = "Anna Bergsson",
                            DateRegistered = new DateTime(2023, 7, 27, 10, 48, 39, 861, DateTimeKind.Utc).AddTicks(4781),
                            EscapeAttempts = 0,
                            Name = "Dundy",
                            Neutered = 0,
                            OwnerId = 1,
                            Sex = 0,
                            SpeciesId = 4,
                            WeightInKilos = 0m
                        },
                        new
                        {
                            Id = 4,
                            Chipped = 0,
                            CreatedBy = "Anna Bergsson",
                            DateRegistered = new DateTime(2023, 7, 27, 10, 48, 39, 861, DateTimeKind.Utc).AddTicks(4797),
                            EscapeAttempts = 0,
                            Name = "Urshy",
                            Neutered = 0,
                            OwnerId = 2,
                            Sex = 1,
                            SpeciesId = 2,
                            WeightInKilos = 5m
                        },
                        new
                        {
                            Id = 5,
                            Chipped = 2,
                            CreatedBy = "Anna Bergsson",
                            DateOfBirth = new DateTime(2023, 7, 27, 12, 48, 39, 861, DateTimeKind.Local).AddTicks(4802),
                            DateRegistered = new DateTime(2023, 7, 27, 10, 48, 39, 861, DateTimeKind.Utc).AddTicks(4800),
                            EscapeAttempts = 6,
                            Name = "Sebastian",
                            Neutered = 2,
                            OwnerId = 2,
                            Sex = 1,
                            SpeciesId = 3,
                            WeightInKilos = 9m
                        },
                        new
                        {
                            Id = 6,
                            Chipped = 2,
                            CreatedBy = "Anna Bergsson",
                            DateOfBirth = new DateTime(2023, 7, 27, 12, 48, 39, 861, DateTimeKind.Local).AddTicks(4870),
                            DateRegistered = new DateTime(2023, 7, 27, 10, 48, 39, 861, DateTimeKind.Utc).AddTicks(4868),
                            EscapeAttempts = 0,
                            Name = "Jessie",
                            Neutered = 1,
                            OwnerId = 2,
                            Sex = 2,
                            SpeciesId = 2,
                            WeightInKilos = 2m
                        },
                        new
                        {
                            Id = 7,
                            Chipped = 1,
                            CreatedBy = "Anna Bergsson",
                            DateOfBirth = new DateTime(2023, 7, 27, 12, 48, 39, 861, DateTimeKind.Local).AddTicks(4883),
                            DateRegistered = new DateTime(2023, 7, 27, 10, 48, 39, 861, DateTimeKind.Utc).AddTicks(4882),
                            EscapeAttempts = 3,
                            Name = "Quiffy",
                            Neutered = 1,
                            OwnerId = 2,
                            Sex = 2,
                            SpeciesId = 3,
                            WeightInKilos = 3m
                        },
                        new
                        {
                            Id = 8,
                            Chipped = 2,
                            CreatedBy = "Anna Bergsson",
                            DateRegistered = new DateTime(2023, 7, 27, 10, 48, 39, 861, DateTimeKind.Utc).AddTicks(4890),
                            EscapeAttempts = 0,
                            Name = "Woffy",
                            Neutered = 1,
                            OwnerId = 2,
                            Sex = 1,
                            SpeciesId = 3,
                            WeightInKilos = 4m
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.AnimalImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("AnimalImageUrl")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("AnimalImages");
                });

            modelBuilder.Entity("DataAccess.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 33,
                            Email = "annamari@uit.no",
                            Name = "Anna Mari Larsen"
                        },
                        new
                        {
                            Id = 2,
                            Age = 42,
                            Email = "kris@uit.no",
                            Name = "Kris Iversen"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Species");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Unknown"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Cat is a domestic species of small carnivorous mammal.",
                            Name = "Cat"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Dog is is a domesticated descendant of the wolf. Also called the domestic dog, it is derived from the extinct Pleistocene wolf, and the modern wolf is the dog's nearest living relative.",
                            Name = "Dog"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Fish are aquatic, craniate, gill-bearing animals that lack limbs with digits. Included in this definition are the living hagfish, lampreys, and cartilaginous and bony fish as well as various extinct related groups.",
                            Name = "Fish"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Rodents (from Latin rodere, 'to gnaw') are mammals of the order Rodentia (/roʊˈdɛnʃə/), which are characterized by a single pair of continuously growing incisors in each of the upper and lower jaws. About 40% of all mammal species are rodents.",
                            Name = "Rodent"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Vet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfGraduation")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Vets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 33,
                            DateOfGraduation = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kjartan Olsen"
                        },
                        new
                        {
                            Id = 2,
                            Age = 27,
                            DateOfGraduation = new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sofia Andersen"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Visit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VetId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VisitDateTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("VetId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("SpeciesVet", b =>
                {
                    b.Property<int>("SpecializationsId")
                        .HasColumnType("int");

                    b.Property<int>("VetsId")
                        .HasColumnType("int");

                    b.HasKey("SpecializationsId", "VetsId");

                    b.HasIndex("VetsId");

                    b.ToTable("SpeciesVet");

                    b.HasData(
                        new
                        {
                            SpecializationsId = 1,
                            VetsId = 1
                        },
                        new
                        {
                            SpecializationsId = 2,
                            VetsId = 2
                        },
                        new
                        {
                            SpecializationsId = 3,
                            VetsId = 1
                        },
                        new
                        {
                            SpecializationsId = 4,
                            VetsId = 1
                        },
                        new
                        {
                            SpecializationsId = 4,
                            VetsId = 2
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Animal", b =>
                {
                    b.HasOne("DataAccess.Entities.Owner", "Owner")
                        .WithMany("Animals")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Species", "Species")
                        .WithMany("Animals")
                        .HasForeignKey("SpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Species");
                });

            modelBuilder.Entity("DataAccess.Entities.AnimalImage", b =>
                {
                    b.HasOne("DataAccess.Entities.Animal", "Animal")
                        .WithMany("AnimalImages")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("DataAccess.Entities.Visit", b =>
                {
                    b.HasOne("DataAccess.Entities.Animal", "Animal")
                        .WithMany("Visits")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Vet", "Vet")
                        .WithMany("Visits")
                        .HasForeignKey("VetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Vet");
                });

            modelBuilder.Entity("SpeciesVet", b =>
                {
                    b.HasOne("DataAccess.Entities.Species", null)
                        .WithMany()
                        .HasForeignKey("SpecializationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Vet", null)
                        .WithMany()
                        .HasForeignKey("VetsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.Animal", b =>
                {
                    b.Navigation("AnimalImages");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("DataAccess.Entities.Owner", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("DataAccess.Entities.Species", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("DataAccess.Entities.Vet", b =>
                {
                    b.Navigation("Visits");
                });
#pragma warning restore 612, 618
        }
    }
}
