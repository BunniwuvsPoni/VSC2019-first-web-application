using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VSC2019_first_web_application.Models;

namespace VSC2019_first_web_application.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly VSC2019_first_web_application.Models.MovieContext _context;

        public IndexModel(VSC2019_first_web_application.Models.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
