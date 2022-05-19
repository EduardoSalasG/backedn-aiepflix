using System.ComponentModel.DataAnnotations;

namespace backedn_aiepflix.DTOs
{
    public class PeliculaCreacion
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Poster { get; set; }
        public int Year { get; set; }
    }
}
