using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities
{
    public class Carrito
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public Estado Estado { get; set; } = Estado.ALTA;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaModificacion { get; set; }

        public Usuario Usuario { get; set; } = null!;
        public ICollection<CarritoItem> Items { get; set; } = new List<CarritoItem>();

    }
}
