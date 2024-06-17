
using BoletoBus.Domain.Core;

namespace BoletoBus.Domain.Entities
{
    public class Usuario : Person
    {

        public string? TipoUsuario { get; set; }
        public ICollection<Reserva>? Reservas { get; set; }
    }
}
