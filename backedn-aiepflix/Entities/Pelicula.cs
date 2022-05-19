using System.ComponentModel.DataAnnotations;

namespace backedn_aiepflix.Entities
{
    public class Pelicula
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Poster { get; set; }
        public int Year { get; set; }

    }
}
