using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.EF;
using System.Threading.Tasks;

namespace RazorPagesMovie.Pages.Movie
{
    public class DeleteModel : BasePageContext
    {

        public DeleteModel(RazorPagesMovieContext context) 
            : base(context) { } 

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            const string INDEX = "./Index";

            if (id == null)
            {
                return NotFound();
            }

            Movie = await Context.Movies.FindAsync(id);

            if (Movie == null) { return RedirectToPage(INDEX); }
            Context.Movies.Remove(Movie);
            await Context.SaveChangesAsync();

            return RedirectToPage(INDEX);
        }
    }
}
