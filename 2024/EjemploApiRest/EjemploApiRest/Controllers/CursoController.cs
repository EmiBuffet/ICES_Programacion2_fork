using EjemploApiRest.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemploApiRest.Controllers
{
    [ApiController]
    [Route("api/curso")]
    public class CursoController : ControllerBase
    {
        static List<Alumno> alumnoList1 = new List<Alumno>
        {
            new Alumno(1, "Juan", "Perez"),
            new Alumno(2, "Lionel", "Messi")
        };

        static List<Alumno> alumnoList2 = new List<Alumno>
        {
            new Alumno(1, "Diego", "Maradona"),
            new Alumno(2, "Juan Roman", "Riquelme")
        };

        static List<Curso> cursos = new List<Curso>
        {
            new Curso(1, "Programación 2", alumnoList1),
            new Curso(2, "Base de datos", alumnoList2)
        };

        [HttpGet]
        public List<Curso> ObtenerCursos(string? nombre)
        {
            
            return cursos.FindAll(x => x.Nombre == nombre);
        }

        [HttpGet("{id}")]
        public ActionResult ObtenerCurso(int id)
        {
            var curso = cursos.Find(x => x.Id == id);

            if (curso == null)
            {
                return NotFound();
            }

            return Ok(curso);
        }
    }
}
