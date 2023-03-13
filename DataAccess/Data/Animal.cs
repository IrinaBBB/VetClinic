using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Data
{
    public class Animal
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Species { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? WeightInKilos { get; set; }
        public bool? Neutered { get; set; }
        public bool Chipped { get; set; }
        public int EscapeAttempts { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime DateRegistered { get; set; } = DateTime.UtcNow;
        public DateTime? DateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set;}
    }
}

