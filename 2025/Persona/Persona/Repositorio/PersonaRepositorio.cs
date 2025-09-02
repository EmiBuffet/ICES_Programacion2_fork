
using Persona.Datos;

namespace Persona.Repositorio
{
    public class PersonaRepositorio : IPersonaRepositorio
    {
        private readonly ApplicationDbContext _context;

        public PersonaRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        public Datos.Entidades.Persona ObtenerPersona(int id)
        {
            return _context.Persona.FirstOrDefault(x => x.id == id);
        }
    }
}
