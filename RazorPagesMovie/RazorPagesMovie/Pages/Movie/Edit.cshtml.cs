using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.EF;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Pages.Movie
{
    public class EditModel : BasePageContext
    {
        public EditModel(RazorPagesMovieContext context) 
            : base(context){}

        [BindProperty]
        public Domain.Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            Movie = await Context.Movie.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Context.Attach(Movie).State = EntityState.Modified;

            try
            {
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(Movie.Id))
                {
                    return NotFound();
                }
                throw;
            }

            return RedirectToPage("./Index");
        }

        private bool MovieExists(int id)
        {
            return Context.Movie.Any(e => e.Id == id);
        }
    }
}
