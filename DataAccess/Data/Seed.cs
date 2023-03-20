using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Data
{
    public class Seed
    {
        public static void addData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Species>().HasData(new List<Species>() 
            {
                new Species() { Id = 1, Name = "Cat", Description = "Cat is a domestic species of small carnivorous mammal."},
                new Species() { Id = 2, Name = "Dog", Description = "Dog is is a domesticated descendant of the wolf. Also called the domestic dog, it is derived from the extinct Pleistocene wolf, and the modern wolf is the dog's nearest living relative."},
                new Species() { Id = 3, Name = "Fish", Description = "Fish are aquatic, craniate, gill-bearing animals that lack limbs with digits. Included in this definition are the living hagfish, lampreys, and cartilaginous and bony fish as well as various extinct related groups."}
            });

            modelBuilder.Entity<Animal>().HasData(new List<Animal>() {
                new Animal() 
                {
                    Id = 1,
                    Name = "Lad",
                    DateOfBirthIsKnown = false,
                    Neutered = Neutered.Unknown,
                    Chipped= Chipped.Unknown,
                    Sex= Sex.Male,
                    WeightInKilos = (decimal) 3.0,
                    EscapeAttempts = 0,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 2
                },
                new Animal() 
                {
                    Id = 2,
                    Name = "Inka",
                    DateOfBirthIsKnown = true,
                    DateOfBirth = DateTime.Now,
                    Neutered = Neutered.Yes,
                    Chipped= Chipped.Yes,
                    Sex= Sex.Female,
                    WeightInKilos = (decimal) 2.0,
                    EscapeAttempts = 0,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 1
                },
                new Animal() 
                {
                    Id = 3,
                    Name = "Dundy",
                    DateOfBirthIsKnown = false,
                    Neutered = Neutered.Unknown,
                    Chipped= Chipped.Unknown,
                    Sex= Sex.Unknown,
                    WeightInKilos = (decimal) 0.0,
                    EscapeAttempts = 0,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 3
                },
                new Animal() 
                {
                    Id = 4,
                    Name = "Urshy",
                    DateOfBirthIsKnown = false,
                    Neutered = Neutered.Unknown,
                    Chipped= Chipped.Unknown,
                    Sex= Sex.Male,
                    WeightInKilos = (decimal) 5.0,
                    EscapeAttempts = 0,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 1
                },
                new Animal() 
                {
                    Id = 5,
                    Name = "Sebastian",
                    DateOfBirthIsKnown = true,
                    DateOfBirth = DateTime.Now,
                    Neutered = Neutered.No,
                    Chipped= Chipped.No,
                    Sex= Sex.Male,
                    WeightInKilos = (decimal) 9.0,
                    EscapeAttempts = 6,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 2
                },
                new Animal() 
                {
                    Id = 6,
                    Name = "Jessie",
                    DateOfBirthIsKnown = true,
                    DateOfBirth = DateTime.Now,
                    Neutered = Neutered.Yes,
                    Chipped= Chipped.No,
                    Sex= Sex.Female,
                    WeightInKilos = (decimal) 2.0,
                    EscapeAttempts = 0,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 1
                },
                new Animal() 
                {
                    Id = 7,
                    Name = "Quiffy",
                    DateOfBirthIsKnown = true,
                    DateOfBirth = DateTime.Now,
                    Neutered = Neutered.Yes,
                    Chipped= Chipped.Yes,
                    Sex= Sex.Female,
                    WeightInKilos = (decimal) 3.0,
                    EscapeAttempts = 3,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 2
                },
                new Animal()
                {
                    Id = 8,
                    Name = "Woffy",
                    DateOfBirthIsKnown = false,
                    Neutered = Neutered.Yes,
                    Chipped= Chipped.No,
                    Sex= Sex.Male,
                    WeightInKilos = (decimal) 4.0,
                    EscapeAttempts = 0,
                    CreatedBy = "Anna Bergsson",
                    SpeciesId = 2
                },
            });
        }
    }
}
