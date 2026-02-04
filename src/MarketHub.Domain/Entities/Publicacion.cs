using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities
{
    public class Publicacion
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int IdVendedor { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public EstadoPublicacion EstadoPublicacion { get; set; } = EstadoPublicacion.BORRADOR;
        public Estado Estado { get; set; } = Estado.ALTA;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaPublicacion { get; set; }

        public Producto Producto { get; set; } = null!;
        public Usuario Vendedor { get; set; } = null!;
        public ICollection<OrdenDetalle> OrdenDetalles { get; set; } = new List<OrdenDetalle>();

    }
}
