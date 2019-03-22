using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetWebApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new MovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>()))
            {
                // Look for any movies.
                if(context.Movie.Any())
                {
                    return; // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = Genre.ROMANCE,//new List<Genre>(){ Genre.ROMANCE, Genre.COMEDY },
                        Price = 7.99M,
                        Rating = 3.5
                    },
                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = Genre.COMEDY,//new List<Genre>(){ Genre.COMEDY },
                        Price = 8.99M,
                        Rating = 4.8
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = Genre.COMEDY,//new List<Genre>(){ Genre.COMEDY },
                        Price = 9.99M,
                        Rating = 4.3
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = Genre.WESTERN,//new List<Genre>(){ Genre.WESTERN },
                        Price = 3.99M,
                        Rating = 4.0
                    }
                    // --------------------------------------
                    // new Movie
                    // {
                    //     Title = "When Harry Met Sally",
                    //     ReleaseDate = DateTime.Parse("1989-2-12"),
                    //     Genre = "ROMANCE", //Genre.ROMANCE,//new List<Genre>(){ Genre.ROMANCE, Genre.COMEDY },
                    //     Price = 7.99M,
                    //     Rating = 3.5
                    // },
                    // new Movie
                    // {
                    //     Title = "Ghostbusters ",
                    //     ReleaseDate = DateTime.Parse("1984-3-13"),
                    //     Genre = "COMEDY", //Genre.COMEDY,//new List<Genre>(){ Genre.COMEDY },
                    //     Price = 8.99M,
                    //     Rating = 4.8
                    // },
                    // new Movie
                    // {
                    //     Title = "Ghostbusters 2",
                    //     ReleaseDate = DateTime.Parse("1986-2-23"),
                    //     Genre = "COMEDY", //Genre.COMEDY,//new List<Genre>(){ Genre.COMEDY },
                    //     Price = 9.99M,
                    //     Rating = 4.3
                    // },
                    // new Movie
                    // {
                    //     Title = "Rio Bravo",
                    //     ReleaseDate = DateTime.Parse("1959-4-15"),
                    //     Genre = "WESTERN", //Genre.WESTERN,//new List<Genre>(){ Genre.WESTERN },
                    //     Price = 3.99M,
                    //     Rating = 4.0
                    // }
                );
                context.SaveChanges();
            }
        }
        
    }
}