using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Domain;

namespace RazorPagesMovie.EF
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options)
            : base(options) {}

        public DbSet<Movie> Movies { get; set; }

        #region Overrides of DbContext

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>();
            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
