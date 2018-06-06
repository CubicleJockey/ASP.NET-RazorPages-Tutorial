using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.EF;

namespace RazorPagesMovie.Pages.Movie
{
    public class CreateModel : BasePageContext
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

            Context.Movie.Add(Movie);
            await Context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }


    }
}