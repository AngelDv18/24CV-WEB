namespace _24CV_WEB.Models
{
    public class EmailViewModel
    {
        public string Email { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public Turno TurnoSelect { get; set; }

        public string Comentario { get; set; }

    }

    public enum Turno
    {
        Matutino,
        Vespertino
    }
}
