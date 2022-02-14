using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TareaRazorPage.Models
{
    public class Juego
    {
        public int ID { get; set; }
        [Display(Name = "Titulo del juego")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Fecha de lanzamiento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Genero del juego")]
        public string Genre { get; set; } = string.Empty;

        [Display(Name = "Precio del juego")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }



    }
}
