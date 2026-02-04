using Microsoft.EntityFrameworkCore;

namespace MarketHub.Infrastructure.Data;

/// <summary>
/// Contexto principal de base de datos. Es el puente entre C# y MySQL.
/// </summary>
public class MarketHubDbContext : DbContext
{
    // DbContextOptions: contiene el connection string y configuración de la conexión.
    // Se inyecta desde Program.cs
    public MarketHubDbContext(DbContextOptions<MarketHubDbContext> eOpciones)
        : base(eOpciones)
    {
    }

    // Acá van los DbSet<Entidad> que representan las tablas.
    // Ejemplo: public DbSet<Usuario> Usuarios { get; set; }

    // OnModelCreating: se ejecuta al iniciar la app para configurar el modelo (relaciones, índices, etc.)
    protected override void OnModelCreating(ModelBuilder eModelBuilder)
    {
        base.OnModelCreating(eModelBuilder);

        // Aplica automáticamente las configuraciones de entidades desde archivos separados
        eModelBuilder.ApplyConfigurationsFromAssembly(typeof(MarketHubDbContext).Assembly);
    }
}
