using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options) : base(options)
        {

        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieId = 1,
                    Category = "Fantasy",
                    Title = "Avatar the Last Airbender",
                    Year = 2005,
                    Director = "Dave Filoni",
                    Rating = "G",
                    Edited = false,
                    LentTo = "John",
                    Notes = "Uncle Iroh is the best"
                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    Category = "Fantasy",
                    Title = "Harry Potter and the Prisoner of Azkaban",
                    Year = 2004,
                    Director = "Alfonso Cuaron",
                    Rating = "PG",
                    Edited = true,
                    LentTo = "Dustin",
                    Notes = "The best of all the Harry Potter Movies"

                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    Category = "RomCom",
                    Title = "White Christmas",
                    Year = 1954,
                    Director = "Michael Curtiz",
                    Rating = "G",
                    Edited = false,
                    LentTo = "Jackson",
                    Notes = "Best Christmas movie ever. (Should watch at least 5 times per year)"

                }
            );
        }
    }
}
