using AlumnosMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlumnosMVC.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConsultarAlumno(string nombre)
        {

            var alumno = new Alumno(nombre, "Buffet");


            //ViewData["nombre"] = nombre;

            return View(alumno);
        }
    }
}
