using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace DotNetWebApp.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<DotNetWebApp.Models.Movie> Movie { get; set; }
    }
}