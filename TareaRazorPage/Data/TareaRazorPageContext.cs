#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareaRazorPage.Models;

namespace TareaRazorPage.Data
{
    public class TareaRazorPageContext : DbContext
    {
        public TareaRazorPageContext (DbContextOptions<TareaRazorPageContext> options)
            : base(options)
        {
        }

        public DbSet<TareaRazorPage.Models.Juego> Juego { get; set; }
    }
}
