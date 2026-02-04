using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities
{
    public class Imagen
    {
        public int Id { get; set; }
        public int IdCarrito { get; set; }
        public int IdPublicacion { get; set; }
        public int Cantidad { get; set; }
        public Estado Estado { get; set; } = Estado.ALTA;
        public DateTime FechaAgregado { get; set; } = DateTime.UtcNow;

        public Carrito Carrito { get; set; } = null!;
        public Publicacion Publicacion { get; set; } = null!;
    }
}
