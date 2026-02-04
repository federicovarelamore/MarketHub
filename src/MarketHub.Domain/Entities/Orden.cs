using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities
{
    public class Orden
    {
        public int Id { get; set; }
        public int IdComprador { get; set; }
        public int IdMetodoPago { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public decimal Total { get; set; }
        public EstadoOrden EstadoOrden { get; set; } = EstadoOrden.PENDIENTE;
        public Estado Estado { get; set; } = Estado.ALTA;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaPago { get; set; }

        public Usuario Comprador { get; set; } = null!;
        public MetodoPago MetodoPago { get; set; } = null!;
        public ICollection<OrdenDetalle> OrdenDetalles { get; set; } = new List<OrdenDetalle>();
    }
}
