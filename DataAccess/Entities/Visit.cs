using System;

namespace DataAccess.Entities
{
    public class Visit
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int VetId { get; set; }
        public Vet Vet { get; set; }
        public DateTime VisitDateTime { get; set; }
        public string Details { get; set; }
    }
}



