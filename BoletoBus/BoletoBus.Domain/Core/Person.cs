namespace BoletoBus.Domain.Core
{
    public abstract class Person : AuditableEntity
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public int IdUsuario { get; set; }

    }
}
