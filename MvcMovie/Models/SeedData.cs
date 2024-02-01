using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
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
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Rating = "R+",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "The Avengers",
                    ReleaseDate = DateTime.Parse("2012-04-05"),
                    Genre = "Sci-Fic",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "The Avengers: Age Of Ultron",
                    ReleaseDate = DateTime.Parse("2009-3-13"),
                    Genre = "Advanchure",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "The aAvengers: Infinity Wars",
                    ReleaseDate = DateTime.Parse("2007-2-23"),
                    Genre = "Action",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Avengers: End Game",
                    ReleaseDate = DateTime.Parse("2020-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The Avengers: Final Game",
                    ReleaseDate = DateTime.Parse("2021-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                }

            );
            context.SaveChanges();
            if (context.Movie.Any())
            {
                return;  // DB has been seeded.
            }
        }
    }
}