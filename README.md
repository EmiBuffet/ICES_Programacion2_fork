# ICES Programacion2

Configuración Entity Framwork

Documentacion: https://learn.microsoft.com/es-es/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-8.0&tabs=visual-studio

1 Agregar paquete Nuget
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
  
2 Crear carpeta Data  

    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
       {
  
       }
       public DbSet<.Persona> Persona { get; set; } = default!;

    }}


3 appsettings.json

"ConnectionStrings": { "ApplicationDbContext": "Server=localhost\\SQLEXPRESS;Database=PruebaApi;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;" }

4 Program.cs

builder.Services.AddDbContext<ApplicationDbContext>(options =>

options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContext")));

5 En Herramientas -> Administrador de paquetes NuGet -> Consolta del administrador de paquetes : Ejecutar los comandos 1 - Add-Migration MigracionInicial y 2 - Update-Database 

6 En el controlador creado agregar

    private readonly ApplicationDbContext _context;

    public PersonaController(ApplicationDbContext context)
    {
        _context = context;
    }
