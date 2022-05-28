namespace backedn_aiepflix.DTOs
{
    public class RutResponse
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string NombreActividad { get; set; }
        public int CodigoActividad { get; set; }
        public bool AfectoIVA { get; set; }
        public DateTime FechaInicioAct { get; set; }
        public string Status { get; set; }
    }
}
