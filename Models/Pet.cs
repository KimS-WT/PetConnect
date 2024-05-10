using System.ComponentModel.DataAnnotations;

namespace PetConnect.Models
{
    public class Pet
    {
        public int PetId { get; set; } // Primary Key

        [Required(ErrorMessage = "Pet name is required.")]
        public string Name { get; set; } = string.Empty;

        [Range(0, 100, ErrorMessage = "Age must be between 0 and 100.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Species is required.")]
        public string Species { get; set; } = string.Empty;

        [Required(ErrorMessage = "Breed is required.")]
        public string Breed { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        
        public int? ShelterId { get; set; }

        // Navigation property
        public Shelter? Shelters { get; set; } = default!;
    }
}