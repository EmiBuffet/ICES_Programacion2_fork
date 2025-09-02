using Microsoft.EntityFrameworkCore;

namespace Persona.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Datos.Entidades.Persona> Persona { get; set; } = default!;

    }
}
