using BoletoBus.Domain.Entities;

namespace BoletoBus.Domain.Models
{
    public class ReservaDetalleModel
    {
        public int IdReserva { get; set; }
        public int IdAsiento { get; set; }

        public ReservaModel Reserva { get; set; }
        public AsientoModel Asiento { get; set; }

    }
}
