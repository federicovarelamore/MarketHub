using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities;

public class Favorito
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public int IdPublicacion { get; set; }
    public Estado Estado { get; set; } = Estado.ALTA;
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    public Usuario Usuario { get; set; } = null!;
    public Publicacion Publicacion { get; set; } = null!;
}
