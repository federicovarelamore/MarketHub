using MarketHub.Domain.Enums;

namespace MarketHub.Domain.Entities
{
    public class Direccion
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Calle { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string? Piso { get; set; }
        public string? Departamento { get; set; }
        public string Ciudad { get; set; } = string.Empty;
        public string Provincia { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
        public string? Referencia { get; set; }
        public bool EsPrincipal { get; set; } = false;
        public Estado Estado { get; set; } = Estado.ALTA;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public Usuario Usuario { get; set; } = null!;
    }
}
