using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public enum Sex
    {
        Male = 1, Female = 2, Unknown = 0
    }

    public enum Neutered
    {
        Yes = 1, No = 2, Unknown = 0
    }

    public enum Chipped
    {
        Yes = 1, No = 2, Unknown = 0
    }

    public class Animal
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool DateOfBirthIsKnown { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Neutered Neutered { get; set; }
        public Chipped Chipped { get; set; }
        public Sex Sex { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? WeightInKilos { get; set; }
        public int EscapeAttempts { get; set; }

        public DateTime DateRegistered { get; set; } = DateTime.UtcNow;
        public DateTime? DateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int? SpeciesId { get; set; }
        public Species? Species { get; set; }
    }
}

