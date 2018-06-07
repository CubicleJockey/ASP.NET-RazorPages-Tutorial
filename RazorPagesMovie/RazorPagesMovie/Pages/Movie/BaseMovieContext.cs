using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.EF;

namespace RazorPagesMovie.Pages.Movie
{
    public abstract class BaseMovieContext : PageModel
    {
        protected RazorPagesMovieContext Context { get; }

        protected BaseMovieContext(RazorPagesMovieContext context)
        {
            Context = context;
        }
    }
}
