using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.EF;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorPagesMovie.Pages.Movie
{
    public class IndexModel : BasePageContext
    {
        public IndexModel(RazorPagesMovieContext context) 
            : base(context) { }

        public IEnumerable<Domain.Movie> Movies { get;set; }

        public async Task OnGetAsync()
        {
            Movies = await Context.Movies.ToListAsync();
        }
    }
}
