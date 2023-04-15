using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using DataAccess.Entities;

namespace Model
{
    public class AnimalDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a pet name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter species")]
        public DateTime? DateOfBirth { get; set; }
        public Neutered Neutered { get; set; }
        public Chipped Chipped { get; set; }
        public Sex Sex { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1000, ErrorMessage = "Weight should be between 1 and 1000 kilos")]
        public decimal? WeightInKilos { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Escape attempts number should be greater than 0")]
        public int EscapeAttempts { get; set; }
        public int? SpeciesId { get; set; }
        public Species Species { get; set; }
    }
}
