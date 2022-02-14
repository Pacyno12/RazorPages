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
    public class DetailsModel : PageModel
    {
        private readonly TareaRazorPage.Data.TareaRazorPageContext _context;

        public DetailsModel(TareaRazorPage.Data.TareaRazorPageContext context)
        {
            _context = context;
        }

        public Juego Juego { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Juego = await _context.Juego.FirstOrDefaultAsync(m => m.ID == id);

            if (Juego == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
