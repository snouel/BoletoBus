/*Esto se utiliza para manejar todo lo relacionado a las excepciones controladas*/

namespace BoletoBus.Infraestructure.Exceptions
{
    public class AsientoDataException : Exception
    {
        public AsientoDataException(string message) : base(message)
        {
            // Logica para enviar el correo y loggear el error. 


        }
    }
}
