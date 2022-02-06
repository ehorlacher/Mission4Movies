using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Movies.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //Leave blank
        }

        public DbSet<MovieModel> MovieInputs { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieModel>().HasData(

                new MovieModel
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "Avengers",
                    Year = 2021,
                    Director = "Joss Wheadon",
                    Rating = "PG-13",
                    Lent_To = "",
                    Notes = "Slam dunk movie."
                },
                new MovieModel
                {
                    MovieID = 2,
                    Category = "Action/Adventure",
                    Title = "Star Wars",
                    Year = 1977,
                    Director = "George Lucas",
                    Rating = "PG",
                    Lent_To = "",
                    Notes = "The O.G."
                },
                new MovieModel
                {
                    MovieID = 3,
                    Category = "Drama",
                    Title = "Avengers",
                    Year = 2000,
                    Director = "Boaz Yakin",
                    Rating = "PG",
                    Lent_To = "",
                    Notes = "A real tear-jerker."
                }

            );
        }
    }
}
