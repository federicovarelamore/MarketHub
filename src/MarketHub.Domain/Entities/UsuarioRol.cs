using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities
{
    public class UsuarioRol
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public Estado Estado { get; set; } = Estado.ALTA;
        public DateTime FechaAsignacion { get; set; } = DateTime.UtcNow;

        public Usuario Usuario { get; set; } = null!;
        public Rol Rol { get; set; } = null!;
    }
}
