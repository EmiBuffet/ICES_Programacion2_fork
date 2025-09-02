using EjemploDto.Data;
using EjemploDto.Dtos;
using EjemploDto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EjemploDto.Controllers
{
    [ApiController]
    [Route("personas")]
    public class PersonaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Persona> ConsultarPersonas(string nombre)
        {
            string query = "SELECT * FROM Persona WHERE nombre = '" + nombre + "'";
            var persona = _context.Persona
                               .FromSqlRaw(query)
                               .ToList();

            //Solucion
            /* var persona = _context.Persona
                               .Where(u => u.nombre == nombre)
                               .ToList();
            */
            return persona;
        }

        [HttpPost]
        public async Task<int> CrearPersonaAsync(PersonaDto personaDto)
        {
            //Pasar los datos del DTO a la clase de Modelo
            Persona persona = new Persona();
            persona.Nombre = personaDto.Nombre;
            persona.Apellido = personaDto.Apellido;

            //Guardar en la base
            _context.Add(persona);
            await _context.SaveChangesAsync();
            return persona.Id;
        }
    }
}
