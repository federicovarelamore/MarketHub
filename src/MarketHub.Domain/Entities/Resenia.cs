using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities
{
    public class Resenia
    {
        public int Id { get; set; }
        public int IdPublicacion { get; set; }
        public int IdComprador { get; set; }
        public int IdOrden { get; set; }
        public int Puntuacion { get; set; }
        public string? Comentario { get; set; }
        public Estado Estado { get; set; } = Estado.ALTA;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public Publicacion Publicacion { get; set; } = null!;
        public Usuario Comprador { get; set; } = null!;
        public Orden Orden { get; set; } = null!;
    }
}
