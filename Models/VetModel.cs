using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace Model
{
    public class VetModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(18, int.MaxValue, ErrorMessage = "Please enter a valid age value")]
        public int Age { get; set; }
        public string ImageFileName { get; set; }
        public DateTime? DateOfGraduation { get; set; }
        public ICollection<Visit> Visits { get; set; }
        public ICollection<Species> Specializations { get; set; }
    }
}
