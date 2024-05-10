using Microsoft.EntityFrameworkCore;
namespace PetConnect.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PetDbContext(
              serviceProvider.GetRequiredService<DbContextOptions<PetDbContext>>()))
            {
                // Look for any Pets.
                if (context.Pets.Any())
                {
                    return; // DB has been seeded
                }
                // DB should seed id automatically
                context.Pets.AddRange(
                    new Pet { Name = "Buddy", Age = 3, Species = "Dog", Breed = "Labrador", Description = "Friendly and energetic." },
                    new Pet { Name = "Charlie", Age = 2, Species = "Dog", Breed = "Beagle", Description = "Loves long walks and howling." },
                    new Pet { Name = "Max", Age = 5, Species = "Dog", Breed = "Bulldog", Description = "Calm and loving, enjoys short walks." },
                    new Pet { Name = "Bella", Age = 2, Species = "Cat", Breed = "Siamese", Description = "Quiet and dignified, loves attention." },
                    new Pet { Name = "Lucy", Age = 4, Species = "Cat", Breed = "Persian", Description = "Loyal and sweet, prefers quiet environments." },
                    new Pet { Name = "Milo", Age = 1, Species = "Cat", Breed = "Maine Coon", Description = "Playful and curious about everything." },
                    new Pet { Name = "Tiger", Age = 6, Species = "Cat", Breed = "Bengal", Description = "Active and loves to climb." },
                    new Pet { Name = "Oscar", Age = 2, Species = "Dog", Breed = "Poodle", Description = "Intelligent and easy to train." },
                    new Pet { Name = "Daisy", Age = 3, Species = "Dog", Breed = "Dachshund", Description = "Playful, loves to chase small animals." },
                    new Pet { Name = "Lola", Age = 5, Species = "Dog", Breed = "Pit Bull", Description = "Friendly with families, energetic." },
                    new Pet { Name = "Bailey", Age = 1, Species = "Dog", Breed = "Golden Retriever", Description = "Enjoys swimming and retrieving games." },
                    new Pet { Name = "Oliver", Age = 3, Species = "Cat", Breed = "American Shorthair", Description = "Chill and down to earth." },
                    new Pet { Name = "Sophie", Age = 2, Species = "Cat", Breed = "Sphynx", Description = "Loves warmth and being the center of attention." },
                    new Pet { Name = "Shadow", Age = 4, Species = "Dog", Breed = "German Shepherd", Description = "Loyal and protective of its family." },
                    new Pet { Name = "Izzy", Age = 3, Species = "Dog", Breed = "Border Collie", Description = "Very energetic and intelligent." },
                    new Pet { Name = "Nala", Age = 2, Species = "Dog", Breed = "Boxer", Description = "Fun-loving and bright, good with kids." },
                    new Pet { Name = "Ruby", Age = 3, Species = "Dog", Breed = "Rottweiler", Description = "Confident guardian, well-mannered." },
                    new Pet { Name = "Rosie", Age = 1, Species = "Cat", Breed = "Ragdoll", Description = "Affectionate and loves to be held." },
                    new Pet { Name = "Zoe", Age = 3, Species = "Dog", Breed = "Cocker Spaniel", Description = "Gentle and affectionate, loves playtime." },
                    new Pet { Name = "Jack", Age = 5, Species = "Dog", Breed = "French Bulldog", Description = "Adapts well to city living, very lovable." },
                    new Pet { Name = "Lily", Age = 2, Species = "Cat", Breed = "Himalayan", Description = "Sweet-natured and playful." },
                    new Pet { Name = "Penny", Age = 3, Species = "Cat", Breed = "Abyssinian", Description = "Smart and curious, enjoys high perches." },
                    new Pet { Name = "Frankie", Age = 4, Species = "Dog", Breed = "Doberman", Description = "Energetic and loyal, excellent guard dog." },
                    new Pet { Name = "Chester", Age = 2, Species = "Cat", Breed = "Norwegian Forest Cat", Description = "Friendly and adapted to cold climates." },
                    new Pet { Name = "Maggie", Age = 5, Species = "Dog", Breed = "Shih Tzu", Description = "Affectionate companion, requires regular grooming." },
                    new Pet { Name = "Gus", Age = 1, Species = "Cat", Breed = "Burmese", Description = "People-oriented and playful." },
                    new Pet { Name = "Coco", Age = 2, Species = "Dog", Breed = "Chihuahua", Description = "Loyal and adventurous, good companion." },
                    new Pet { Name = "Gracie", Age = 3, Species = "Cat", Breed = "Oriental", Description = "Elegant and social, likes to be involved." },
                    new Pet { Name = "George", Age = 4, Species = "Dog", Breed = "Labradoodle", Description = "Friendly and hypoallergenic, good for families with allergies." },
                    new Pet { Name = "Ellie", Age = 5, Species = "Dog", Breed = "Beagle", Description = "Curious and merry, always sniffing." },
                    new Pet { Name = "Henry", Age = 2, Species = "Cat", Breed = "Exotic Shorthair", Description = "Quiet and affectionate, snub-nosed." },
                    new Pet { Name = "Luna", Age = 1, Species = "Cat", Breed = "British Shorthair", Description = "Calm and good-natured." },
                    new Pet { Name = "Sammy", Age = 4, Species = "Dog", Breed = "Samoyed", Description = "Gentle and adaptable, smiley face." },
                    new Pet { Name = "Fiona", Age = 3, Species = "Cat", Breed = "Scottish Fold", Description = "Sweet-tempered, known for unique ear shape." },
                    new Pet { Name = "Jasper", Age = 2, Species = "Cat", Breed = "Turkish Angora", Description = "Vibrant and playful, loves attention." }
                );

                context.SaveChanges();
            }
        }
    }
}
