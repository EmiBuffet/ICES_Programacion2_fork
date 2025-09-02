using Persona.Datos.Dtos;
using Persona.Repositorio;

namespace Persona.Logica
{
    public class PersonaLogica : IPersonaLogica
    {
        private readonly IPersonaRepositorio _personaRepositorio;

        public PersonaLogica(IPersonaRepositorio personaRepositorio)
        {
            _personaRepositorio = personaRepositorio;
        }
        public PersonaDto ObtenerPersona(int id)
        {
            Datos.Entidades.Persona persona = _personaRepositorio.ObtenerPersona(id);

            if (persona == null)
            {
                return null;
            }

            return new PersonaDto
            {
                id = persona.id,
                nombre = persona.nombre
            };
        }
    }
}
