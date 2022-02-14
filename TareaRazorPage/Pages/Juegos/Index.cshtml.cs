#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task OnGetAsync()
        {
            Juego = await _context.Juego.ToListAsync();
        }
    }
}
