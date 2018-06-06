using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.EF;

namespace RazorPagesMovie.Pages.Movie
{
    public abstract class BasePageContext : PageModel
    {
        protected RazorPagesMovieContext Context { get; }

        protected BasePageContext(RazorPagesMovieContext context)
        {
            Context = context;
        }
    }
}
