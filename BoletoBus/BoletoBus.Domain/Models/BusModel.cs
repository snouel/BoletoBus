namespace BoletoBus.Domain.Models
{
    public class BusModel
    {
        public string NumeroPlaca { get; set; }
        public string Nombre { get; set; }
        public bool Disponible { get; set; }
        public ICollection<AsientoModel> Asientos { get; set; }
        public ICollection<ViajeModel> Viajes { get; set; }

    }
}
