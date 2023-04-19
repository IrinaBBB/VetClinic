using DataAccess.Entities;

namespace Model
{
    public class AnimalImageDto
    {
        public int Id { get; set; }
        public string AnimalImageUrl { get; set; }
        public int AnimalId { get; set; }
        public virtual Animal Animal { get; set; }
    }
}