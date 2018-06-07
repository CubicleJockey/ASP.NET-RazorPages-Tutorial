using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.EF;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesMovie.Pages.Movie
{
    public class IndexModel : BasePageContext
    {
        public IndexModel(RazorPagesMovieContext context) 
            : base(context) { }

        public IEnumerable<Domain.Movie> Movies { get;set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }

        public async Task OnGetAsync(string movieGenre, string searchString)
        {
            var genres = Context.Movies.OrderBy(movie => movie.Genre)
                                       .Select(movie => movie.Genre)
                                       .Distinct();

            var movies = Context.Movies.Select(movie => movie);
            if (!string.IsNullOrWhiteSpace(searchString))
            {
                movies = movies.Where(movie => movie.Title.Contains(searchString));
            }

            if (!string.IsNullOrWhiteSpace(movieGenre))
            {
                movies = movies.Where(movie => movie.Genre == movieGenre);
            }

            Genres = new SelectList(await genres.ToArrayAsync());
            Movies = await movies.ToArrayAsync();
        }
    }
}
