using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-2-26"),
                        Genre = "Documentary",
                        Price = 6.0M,
                        Rating= "PG",
                        ImdbID= "tt4003774"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven ",
                        ReleaseDate = DateTime.Parse("2002-4-12"),
                        Genre = "Adventure",
                        Price = 4.7M,
                        Rating="PG",
                        ImdbID= "tt0250371"
                    },

                    new Movie
                    {
                        Title = "The Ten Commandments",
                        ReleaseDate = DateTime.Parse("1956-10-5"),
                        Genre = "Adventure",
                        Price = 65.5M,
                        Rating="G",
                        ImdbID= "tt0049833"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2001-6-2"),
                        Genre = "Adventure",
                        Price = 2.0M,
                        Rating="PG",
                        ImdbID= "tt1909270"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}