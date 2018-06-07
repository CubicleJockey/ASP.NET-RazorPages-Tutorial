using Microsoft.AspNetCore.Mvc;
using RazorPagesMovie.EF;
using System.Threading.Tasks;

namespace RazorPagesMovie.Pages.Movie
{
    public class CreateModel : BaseMovieContext
    {

        /// <inheritdoc />
        public CreateModel(RazorPagesMovieContext context) 
            : base(context) { }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Domain.Movie Movie { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Context.Movies.Add(Movie);
            await Context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }


    }
}