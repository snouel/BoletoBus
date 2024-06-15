using BoletoBus.Domain.Entities;

namespace BoletoBus.Domain.Models
{
    public class ReservaModel
    {
        public int IdReserva { get; set; }
        public int IdViaje { get; set; }
        public int IdPasajero { get; set; }
        public int AsientosReservados { get; set; }
        public decimal MontoTotal { get; set; }
        public ViajeModel Viaje { get; set; }
        public UsuarioModel Pasajero { get; set; }
        public ICollection<ReservaDetalleModel> ReservaDetalles { get; set; }
    }
}
