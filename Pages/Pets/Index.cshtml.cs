using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetConnect.Models;

namespace PetConnect.Pages_Pets
{
    public class IndexModel : PageModel
    {
        private readonly PetConnect.Models.PetDbContext _context;

        private const int PageSize = 10; // Can adjust this number to show more or fewer items per page
        public IndexModel(PetConnect.Models.PetDbContext context)
        {
            _context = context;
        }

        public IList<Pet> Pet { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string PetSpecies { get; set; }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;  // Default to the first page

        public int TotalPages { get; set; } 

        public async Task OnGetAsync(string sortOrder)
        {
            // Pet = await _context.Pets.ToListAsync();
            IQueryable<Pet> petsQuery = from pet in _context.Pets
                                        select pet;

            if (!string.IsNullOrEmpty(SearchString))
            {
                petsQuery = petsQuery.Where(p => p.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(PetSpecies))
            {
                petsQuery = petsQuery.Where(p => p.Species == PetSpecies);
            }

            // This is where sorting logic occurs
            switch (sortOrder)
            {
                case "name_desc":
                    petsQuery = petsQuery.OrderByDescending(p => p.Name);
                    break;
                case "age_asc":
                    petsQuery = petsQuery.OrderBy(p => p.Age);
                    break;
                case "age_desc":
                    petsQuery = petsQuery.OrderByDescending(p => p.Age);
                    break;
                default:
                    petsQuery = petsQuery.OrderBy(p => p.Name);
                    break;
            }

            // Pagination logic
            // Count the total records
            int totalRecords = await petsQuery.CountAsync();
            TotalPages = (int)System.Math.Ceiling(totalRecords / (double)PageSize);

            // Pet = await petsQuery.AsNoTracking().ToListAsync();
            // Adjust the query to fetch only the subset of records
            Pet = await petsQuery.AsNoTracking()
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();
        }
    }
}
