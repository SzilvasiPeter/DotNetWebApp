using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DotNetWebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly DotNetWebApp.Models.MovieContext _context;

        public IndexModel(DotNetWebApp.Models.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public Genre MovieGenre { get; set; }
        public async Task OnGetAsync()
        {
            // IQueryable<string> genreQuery = from m in _context.Movie orderby m.Genre select m.Genre;

            var genreQuery = from m in _context.Movie where m.Genre > 0 select m.Genre;
            
            var movies = from m in _context.Movie select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if(MovieGenre != 0)
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }
            
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
