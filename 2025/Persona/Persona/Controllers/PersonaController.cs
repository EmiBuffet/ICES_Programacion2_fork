using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persona.Datos.Dtos;
using Persona.Logica;

namespace Persona.Controllers
{
    [Route("personas")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaLogica _personaLogica;
        public PersonaController(IPersonaLogica personaLogica)
        {
            _personaLogica = personaLogica;
        }
        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            return Ok("Hola");
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            PersonaDto personaDto = _personaLogica.ObtenerPersona(id);

            if (personaDto == null)
            {
                return NotFound();
            }

            return Ok(personaDto);
        }
    }
}


