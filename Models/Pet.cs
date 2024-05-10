namespace PetConnect.Models
{
    public class Pet
    {
        public int PetId { get; set; } // Primary Key
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
    }
}