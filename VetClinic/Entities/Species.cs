namespace VetClinic.Entities
{
    public class Species
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Animal> Animals { get; set; } = new();
    }
}
