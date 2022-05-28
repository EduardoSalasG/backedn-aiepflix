using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace backedn_aiepflix.Entities
{
    public class RUT
    {
        public int Id { get; set; }
        [Required]
        public string Rut { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string NombreActividad { get; set; }
        [Required]
        public int CodigoActividad { get; set; }
        [Required]
        public bool AfectoIVA { get; set; }
        [Required]
        public DateTime FechaInicioAct { get; set; }    

    }
}
