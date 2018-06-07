using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.EF;
using System.Threading.Tasks;

namespace RazorPagesMovie.Pages.Movie
{
    public class DetailsModel : BasePageContext
    {
        public DetailsModel(RazorPagesMovieContext context) 
            : base(context) { }

        public Domain.Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            Movie = await Context.Movies.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
