namespace AlumnosMVC.Models
{
    public class Alumno
    {   
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Alumno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
