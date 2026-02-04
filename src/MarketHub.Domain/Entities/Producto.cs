using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public Estado Estado { get; set; } = Estado.ALTA;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public Categoria Categoria { get; set; } = null!;
        public ICollection<Publicacion> Publicaciones { get; set; } = new List<Publicacion>();


    }
}
