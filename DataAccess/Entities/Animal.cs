using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public enum Sex
    {
        Male = 1,
        Female = 2,
        Unknown = 0
    }

    public enum Neutered
    {
        Yes = 1,
        No = 2,
        Unknown = 0
    }

    public enum Chipped
    {
        Yes = 1,
        No = 2,
        Unknown = 0
    }

    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Neutered Neutered { get; set; }
        public Chipped Chipped { get; set; }
        public Sex Sex { get; set; }
        public decimal? WeightInKilos { get; set; }
        public int EscapeAttempts { get; set; }
        public DateTime DateRegistered { get; set; } = DateTime.UtcNow;
        public DateTime? DateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int SpeciesId { get; set; }
        public Species Species { get; set; }
        public virtual ICollection<AnimalImage> AnimalImages { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public ICollection<Visit> Visits { get; set; }
    }
}