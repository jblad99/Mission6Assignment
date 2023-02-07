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
            public DbSet<MoviesResponse> Responses { get; set; }
            public DbSet<Category> Category { get; set; }



        protected override void OnModelCreating(ModelBuilder mb)
            {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action" },
                new Category { CategoryId = 2, CategoryName = "Adventure" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Comedy" },
                new Category { CategoryId = 5, CategoryName = "Family" },
                new Category { CategoryId = 6, CategoryName = "Sports" },
                new Category { CategoryId = 7, CategoryName = "Thriller" },
                new Category { CategoryId = 8, CategoryName = "Fantasy" },
                new Category { CategoryId = 9, CategoryName = "Mystery" }
            );

            mb.Entity<MoviesResponse>().HasData(
                new MoviesResponse
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "Skyfall",
                    Year = 2012,
                    Director = "Sam Mendes",
                    Rating = "PG-13",
                    Edited = false
                },
                new MoviesResponse
                {
                    MovieId = 2,
                    CategoryId = 3,
                    Title = "The Pursuit of Happyness",
                    Year = 2006,
                    Director = "Gabriele Muccino",
                    Rating = "PG-13",
                    Edited = false
                },
                new MoviesResponse
                {
                    MovieId = 3,
                    CategoryId = 1,
                    Title = "Spider-Man: No Way Home",
                    Year = 2021,
                    Director = "Jon Watts",
                    Rating = "PG-13",
                    Edited = false
                }
                );
            }
        }
}
