using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Data
{
    public class Seed
    {
        public static void AddData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().HasData(new List<Owner>
            {
                new() { Id = 1, Name = "Anna Mari Larsen", Age = 33, Email = "annamari@uit.no" },
                new() { Id = 2, Name = "Kris Iversen", Age = 42, Email = "kris@uit.no" },
            });

            modelBuilder.Entity<Vet>().HasData(new List<Vet>
            {
                new() { Id = 1, Name = "Kjartan Olsen", Age = 33, DateOfGraduation = DateTime.Parse("Jan 1, 2009") },
                new() { Id = 2, Name = "Sofia Andersen", Age = 27, DateOfGraduation = DateTime.Parse("Jul 14, 2020") },
            });
            modelBuilder.Entity<Species>().HasData(new List<Species>()
            {
                new() { Id = 1, Name = "Unknown" },
                new()
                {
                    Id = 2, Name = "Cat", Description = "Cat is a domestic species of small carnivorous mammal.",
                },
                new()
                {
                    Id = 3, Name = "Dog",
                    Description =
                        "Dog is is a domesticated descendant of the wolf. Also called the domestic dog, it is derived from the extinct Pleistocene wolf, and the modern wolf is the dog's nearest living relative.",
                },
                new()
                {
                    Id = 4, Name = "Fish",
                    Description =
                        "Fish are aquatic, craniate, gill-bearing animals that lack limbs with digits. Included in this definition are the living hagfish, lampreys, and cartilaginous and bony fish as well as various extinct related groups.",
                },
                new()
                {
                    Id = 5, Name = "Rodent",
                    Description =
                        "Rodents (from Latin rodere, 'to gnaw') are mammals of the order Rodentia (/roʊˈdɛnʃə/), which are characterized by a single pair of continuously growing incisors in each of the upper and lower jaws. About 40% of all mammal species are rodents.",
                },
            });

            modelBuilder.Entity("SpeciesVet").HasData(
                new { SpecializationsId = 1, VetsId = 1 },
                new { SpecializationsId = 2, VetsId = 2 },
                new { SpecializationsId = 3, VetsId = 1 },
                new { SpecializationsId = 4, VetsId = 1 },
                new { SpecializationsId = 4, VetsId = 2 }
            );

            modelBuilder.Entity<Animal>().HasData(new List<Animal>()
            {
                new()
                {
                    Id = 1,
                    Name = "Lad",
                    Neutered = Neutered.Unknown,
                    Chipped = Chipped.Unknown,
                    Sex = Sex.Male,
                    WeightInKilos = (decimal)3.0,
                    EscapeAttempts = 0,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 2,
                    OwnerId = 1
                },
                new()
                {
                    Id = 2,
                    Name = "Inka",
                    DateOfBirth = DateTime.Now,
                    Neutered = Neutered.Yes,
                    Chipped = Chipped.Yes,
                    Sex = Sex.Female,
                    WeightInKilos = (decimal)2.0,
                    EscapeAttempts = 0,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 2,
                    OwnerId = 1
                },
                new()
                {
                    Id = 3,
                    Name = "Dundy",
                    Neutered = Neutered.Unknown,
                    Chipped = Chipped.Unknown,
                    Sex = Sex.Unknown,
                    WeightInKilos = (decimal)0.0,
                    EscapeAttempts = 0,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 4,
                    OwnerId = 1
                },
                new()
                {
                    Id = 4,
                    Name = "Urshy",
                    Neutered = Neutered.Unknown,
                    Chipped = Chipped.Unknown,
                    Sex = Sex.Male,
                    WeightInKilos = (decimal)5.0,
                    EscapeAttempts = 0,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 2,
                    OwnerId = 2
                },
                new()
                {
                    Id = 5,
                    Name = "Sebastian",
                    DateOfBirth = DateTime.Now,
                    Neutered = Neutered.No,
                    Chipped = Chipped.No,
                    Sex = Sex.Male,
                    WeightInKilos = (decimal)9.0,
                    EscapeAttempts = 6,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 3,
                    OwnerId = 2
                },
                new()
                {
                    Id = 6,
                    Name = "Jessie",
                    DateOfBirth = DateTime.Now,
                    Neutered = Neutered.Yes,
                    Chipped = Chipped.No,
                    Sex = Sex.Female,
                    WeightInKilos = (decimal)2.0,
                    EscapeAttempts = 0,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 2,
                    OwnerId = 2
                },
                new()
                {
                    Id = 7,
                    Name = "Quiffy",
                    DateOfBirth = DateTime.Now,
                    Neutered = Neutered.Yes,
                    Chipped = Chipped.Yes,
                    Sex = Sex.Female,
                    WeightInKilos = (decimal)3.0,
                    EscapeAttempts = 3,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 3,
                    OwnerId = 2
                },
                new()
                {
                    Id = 8,
                    Name = "Woffy",
                    Neutered = Neutered.Yes,
                    Chipped = Chipped.No,
                    Sex = Sex.Male,
                    WeightInKilos = (decimal)4.0,
                    EscapeAttempts = 0,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 3,
                    OwnerId = 2
                },
            });
        }
    }
}