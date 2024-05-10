using System.ComponentModel.DataAnnotations;

namespace PetConnect.Models
{
    public class Shelter
    {
        public int ShelterId { get; set; } // Primary key

        [Required(ErrorMessage = "Shelter name is required.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; } = string.Empty;

        [Required(ErrorMessage = "Contact information is required.")]
        public string ContactInfo { get; set; } = string.Empty;

        // Navigation property
        public ICollection<Pet> Pets { get; set; } = new List<Pet>(); 
    }
}