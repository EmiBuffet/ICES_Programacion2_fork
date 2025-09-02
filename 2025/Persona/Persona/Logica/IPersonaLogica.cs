using Persona.Datos.Dtos;

namespace Persona.Logica
{
    public interface IPersonaLogica
    {
        PersonaDto ObtenerPersona(int id);
    }
}
