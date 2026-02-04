using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public int? IdCategoriaPadre { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public Estado Estado { get; set; } = Estado.ALTA;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public Categoria? CategoriaPadre { get; set; }
        public ICollection<Categoria> SubCategorias { get; set; } = new List<Categoria>();
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
