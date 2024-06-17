

using BoletoBus.Domain.Models;

namespace BoletoBus.Infraestructure.Extentions
{
    public static class AsientoExtentions
    {
        public static AsientoModel ConvertAsientoEntitytoAsientoModel()
        {
            return new AsientoModel();
        }
    }
}
