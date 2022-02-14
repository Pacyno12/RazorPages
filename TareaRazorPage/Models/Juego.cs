using System.ComponentModel.DataAnnotations;
namespace TareaRazorPage.Models
{
    public class Juego
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }

    }
}
