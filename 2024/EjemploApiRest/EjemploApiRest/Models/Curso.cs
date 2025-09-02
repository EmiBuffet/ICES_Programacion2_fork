namespace EjemploApiRest.Models
{
    public class Curso
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Alumno> Alumnos { get; set;}

        public Curso(int id, string nombre, List<Alumno> alumnos)
        {
            Id = id;
            Nombre = nombre;
            Alumnos = alumnos;
        }
    }
}
