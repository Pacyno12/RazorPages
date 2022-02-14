#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TareaRazorPage.Data;
using TareaRazorPage.Models;

namespace TareaRazorPage.Pages.Juegos
{
    public class CreateModel : PageModel
    {
        private readonly TareaRazorPage.Data.TareaRazorPageContext _context;

        public CreateModel(TareaRazorPage.Data.TareaRazorPageContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Juego Juego { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Juego.Add(Juego);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
