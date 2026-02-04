using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public long IdPerfil { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Estado Estado { get; set; } = Estado.ALTA;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaUltimoAcceso { get; set; }

        public Perfil Perfil { get; set; } = null!;
        public ICollection<UsuarioRol> UsuarioRoles { get; set; } = new List<UsuarioRol>();
    }
}
