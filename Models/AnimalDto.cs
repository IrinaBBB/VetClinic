using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DataAccess.Data;
using System;

namespace Models
{
    public class AnimalDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a pet name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter species")]
        public string Species { get; set; }
        public bool DateOfBirthIsKnown { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Neutered Neutered { get; set; }
        public Chipped Chipped { get; set; }
        public Sex Sex { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1000, ErrorMessage = "Weight should be between 1 and 1000 kilos")]
        public decimal? WeightInKilos { get; set; }

        [Range(0, 1000, ErrorMessage = "Value should be between 0 and 100")]
        public int EscapeAttempts { get; set; }
    }
}
