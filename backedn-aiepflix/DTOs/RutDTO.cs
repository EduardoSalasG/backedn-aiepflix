using System.ComponentModel.DataAnnotations;

namespace backedn_aiepflix.DTOs
{
    public class RutDTO
    {
        [Required]
        public string Rut { get; set; }
    }
}
