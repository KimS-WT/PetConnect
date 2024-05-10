using Microsoft.EntityFrameworkCore;
namespace PetConnect.Models
{
	public class PetDbContext : DbContext
	{
		public PetDbContext (DbContextOptions<PetDbContext> options)
			: base(options)
		{
		}
		public DbSet<Pet> Pets {get; set;} = default!;
	}
}
