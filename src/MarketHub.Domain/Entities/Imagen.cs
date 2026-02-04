using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities
{
    public class Imagen
    {
        public int Id { get; set; }
        public int IdPublicacion { get; set; }
        public string Url { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public int Orden { get; set; } = 0;
        public bool EsPrincipal { get; set; } = false;
        public Estado Estado { get; set; } = Estado.ALTA;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public Publicacion Publicacion { get; set; } = null!;
    }
}
