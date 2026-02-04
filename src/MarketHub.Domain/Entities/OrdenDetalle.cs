using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities
{
    public class OrdenDetalle
    {
        public int Id { get; set; }
        public int IdOrden { get; set; }
        public int IdPublicacion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public Estado Estado { get; set; } = Estado.ALTA;

        public Orden Orden { get; set; } = null!;
        public Publicacion Publicacion { get; set; } = null!;

    }
}
