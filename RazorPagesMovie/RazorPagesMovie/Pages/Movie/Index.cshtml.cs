using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.EF;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Pages.Movie
{
    public class IndexModel : BasePageContext
    {
        public IndexModel(RazorPagesMovieContext context) 
            : base(context) { }

        public IEnumerable<Domain.Movie> Movies { get;set; }

        public async Task OnGetAsync(string searchString)
        {
            var movies = Context.Movies.Select(movie => movie);
            if (!string.IsNullOrWhiteSpace(searchString))
            {
                movies = movies.Where(movie => movie.Title.Contains(searchString));
            }

            Movies = await movies.ToListAsync();
        }
    }
}
