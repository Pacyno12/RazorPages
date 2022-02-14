#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TareaRazorPage.Data;
using TareaRazorPage.Models;

namespace TareaRazorPage.Pages.Juegos
{
    public class IndexModel : PageModel
    {
        private readonly TareaRazorPage.Data.TareaRazorPageContext _context;

        public IndexModel(TareaRazorPage.Data.TareaRazorPageContext context)
        {
            _context = context;
        }

        public IList<Juego> Juego { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string JuegoGenero { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Juego
                                            orderby m.Genre
                                            select m.Genre;

            var juegos = from m in _context.Juego
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                juegos = juegos.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(JuegoGenero))
            {
                juegos = juegos.Where(x => x.Genre == JuegoGenero);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Juego = await juegos.ToListAsync();
        }
    }
}
