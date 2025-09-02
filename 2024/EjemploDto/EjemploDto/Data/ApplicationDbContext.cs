using EjemploDto.Models;
using Microsoft.EntityFrameworkCore;

namespace EjemploDto.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Persona> Persona { get; set; } = default!;
    }
}
