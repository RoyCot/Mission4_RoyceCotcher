using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_RoyceCotcher.Models
{
    public class MovieSubmitContext : DbContext
    {
        public MovieSubmitContext (DbContextOptions<MovieSubmitContext> options) : base (options)
        {

        }

        public DbSet<MovieSubmit> movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieSubmit>().HasData(
                new MovieSubmit
                {
                    MovieId = 1,
                    Category = "Adventure",
                    Title = "Secret Life of Walter Mitty, The",
                    Year = 2013,
                    Director = "Ben Stiller",
                    Rating = "PG",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                },
                new MovieSubmit
                {
                    MovieId = 2,
                    Category = "Animated",
                    Title = "Princess and the Frog, The",
                    Year = 2009,
                    Director = "Ron Clements, John Musker",
                    Rating = "G",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                },
                new MovieSubmit
                {
                    MovieId = 3,
                    Category = "War Drama",
                    Title = "Band of Brothers",
                    Year = 2001,
                    Director = "Phil Alden Robinson, Richard Loncraine, Mikael Salomon, David Nutter, Tom Hanks, David Leland, David Frankel, Tony To",
                    Rating = "TV-MA",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                }
                );
        }
    }
}
