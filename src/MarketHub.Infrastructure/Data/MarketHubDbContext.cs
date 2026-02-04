using MarketHub.Domain.Entities;
using MarketHub.Infrastructure.Conventions;
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

    // Cada DbSet<Entidad> representa una tabla.
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<UsuarioRol> UsuarioRoles { get; set; }
    public DbSet<Perfil> Perfiles { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Publicacion> Publicaciones { get; set; }
    public DbSet<Orden> Ordenes { get; set; }
    public DbSet<OrdenDetalle> OrdenDetalles { get; set; }
    public DbSet<Direccion> Direcciones { get; set; }
    public DbSet<Carrito> Carritos { get; set; }
    public DbSet<CarritoItem> CarritoItems { get; set; }
    public DbSet<Imagen> Imagenes { get; set; }
    public DbSet<Resenia> Resenias { get; set; }
    public DbSet<MetodoPago> MetodosPago { get; set; }
    public DbSet<Favorito> Favoritos { get; set; }

    // ConfigureConventions: se ejecuta ANTES que OnModelCreating, registra reglas globales del modelo
    protected override void ConfigureConventions(ModelConfigurationBuilder eConfigBuilder)
    {
        eConfigBuilder.Conventions.Add(_ => new ForeignKeyNamingConvention());
    }

    // OnModelCreating: se ejecuta al iniciar la app para configurar el modelo (relaciones, índices, etc.)
    protected override void OnModelCreating(ModelBuilder eModelBuilder)
    {
        base.OnModelCreating(eModelBuilder);

        // Aplica automáticamente las configuraciones de entidades desde archivos separados
        eModelBuilder.ApplyConfigurationsFromAssembly(typeof(MarketHubDbContext).Assembly);

        // Restrict en todas las FKs: no se puede borrar un padre si tiene hijos.
        // Nosotros usamos soft delete (Estado = BAJA), nunca DELETE físico.
        foreach (var iRelacion in eModelBuilder.Model.GetEntityTypes()
            .SelectMany(e => e.GetForeignKeys()))
        {
            iRelacion.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }
}
