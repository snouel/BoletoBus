using BoletoBus.Domain.Core;
using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Models;

namespace BoletoBus.Domain.Interfaces
{
    public interface IAsientoRepository : IBaseRepository<Asiento>
    {
        List<AsientoModel> GetAsientos();
        List<AsientoModel> GetAsientosByBus(int busId);
        void TestConnection();
    }
}
