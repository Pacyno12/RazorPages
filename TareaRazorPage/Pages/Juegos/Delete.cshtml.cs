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
    public class DeleteModel : PageModel
    {
        private readonly TareaRazorPage.Data.TareaRazorPageContext _context;

        public DeleteModel(TareaRazorPage.Data.TareaRazorPageContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Juego = await _context.Juego.FindAsync(id);

            if (Juego != null)
            {
                _context.Juego.Remove(Juego);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
