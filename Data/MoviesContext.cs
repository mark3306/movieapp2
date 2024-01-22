using Microsoft.EntityFrameworkCore;

namespace MovieApp.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MovieApp.Models.Movie> Movie { get; set; } = default!;
    }
}
