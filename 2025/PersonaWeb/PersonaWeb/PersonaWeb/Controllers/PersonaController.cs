using Microsoft.AspNetCore.Mvc;
using PersonaWeb.Models;

namespace PersonaWeb.Controllers
{
    public class PersonaController : Controller
    {
        ///Persona/ConsultaPersona
        public IActionResult ConsultarPersona()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7012/personas/");

            PersonaDto personaDto = client.GetAsync("1").Result.Content.ReadFromJsonAsync<PersonaDto>().Result;

            var persona = new ViewModels.Persona
            {
                Nombre = personaDto.nombre,
                Apellido = ""
            };
            return View(persona);
        }
    }
}
