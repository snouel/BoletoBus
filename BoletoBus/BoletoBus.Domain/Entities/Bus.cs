using BoletoBus.Domain.Core;

namespace BoletoBus.Domain.Entities
{
    public sealed class Bus : AuditableEntity
    {
        public int IdBus { get; set; }
        public string NumeroPlaca { get; set; }
        public string Nombre { get; set; }
        public int CapacidadPiso1 { get; set; }
        public int CapacidadPiso2 { get; set; }
        public int CapacidadTotal { get; set; } // CapacidadPiso1 + CapacidadPiso2
        public bool Disponible { get; set; }

        public ICollection<Asiento> Asientos { get; set; }
        public ICollection<Viaje> Viajes { get; set; }

    }
}
