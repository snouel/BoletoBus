namespace BoletoBus.Domain.Models
{
    public class UsuarioModel
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public ICollection<ReservaModel> Reservas { get; set; }

    }
}
