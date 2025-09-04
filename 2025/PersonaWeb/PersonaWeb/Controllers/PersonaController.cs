using Microsoft.AspNetCore.Mvc;
using PersonaWeb.Models;

namespace PersonaWeb.Controllers
{
    public class PersonaController : Controller
    {
        private readonly IConfiguration _configuration;

        public PersonaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Método directamente en el controlador
        private string GetApiEndpoint()
        {
            return _configuration["BackendEndpoint"];
        }

        ///Persona/ConsultaPersona
        public IActionResult ConsultarPersona()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(GetApiEndpoint() + "/personas/");

            PersonaDto personaDto = client.GetAsync("1").Result.Content.ReadFromJsonAsync<PersonaDto>().Result;

            var persona = new ViewModels.Persona
            {
                Nombre = personaDto.nombre,
                Apellido = "12"
            };
            return View(persona);
        }
    }
}
