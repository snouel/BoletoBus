namespace BoletoBus.Domain.Models
{
    public class RutaModel
    {
        public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }

        public ICollection<ViajeModel> Viajes { get; set; }
    }
}
