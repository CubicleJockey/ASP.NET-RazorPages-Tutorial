using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.EF
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options){ }

        public DbSet<RazorPagesMovie.Domain.Movie> Movie { get; set; }
    }
}
