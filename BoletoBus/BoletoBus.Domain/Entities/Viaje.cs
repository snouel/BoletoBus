using BoletoBus.Domain.Core;

namespace BoletoBus.Domain.Entities
{
    public class Viaje : AuditableEntity
    {
        public int IdViaje { get; set; }
        public int IdBus { get; set; }
        public int IdRuta { get; set; }
        public DateTime FechaSalida { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public TimeSpan HoraLlegada { get; set; }
        public decimal Precio { get; set; }
        public int TotalAsientos { get; set; }
        public int AsientosReservados { get; set; }
        public int AsientoDisponibles { get; set; } // TotalAsientos - AsientosReservados
        public bool Completo { get; set; } // TotalAsientos - AsientosReservados < 1
        public Bus Bus { get; set; }
        public Ruta Ruta { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}
