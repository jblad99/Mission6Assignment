using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6Assignment.Models
{
    public class MoviesContext : DbContext
    {
            //Constructor
            public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
            {
                //Leave blank for now
            }

            //Set up set of data called responses, a set of responses from the database
            public DbSet<MoviesResponse> responses { get; set; }

            protected override void OnModelCreating(ModelBuilder mb)
            {
            mb.Entity<MoviesResponse>().HasData(
                new MoviesResponse
                {
                    MovieId = 1,
                    Category = "Action",
                    Title = "Skyfall",
                    Year = 2012,
                    Director = "Sam Mendes",
                    Rating = "PG-13",
                    Edited = false
                }
                );
            }
        }
}
