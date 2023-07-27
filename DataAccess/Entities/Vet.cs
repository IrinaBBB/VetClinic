using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Vet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime? DateOfGraduation { get; set; }
        public ICollection<Visit> Visits { get; set; }
        public ICollection<Species> Specializations { get; set; }
    }
}
