using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities;

public class Perfil
{
    public int Id { get; set; }
    public string Codigo { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public Estado Estado { get; set; } = Estado.ALTA;
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
