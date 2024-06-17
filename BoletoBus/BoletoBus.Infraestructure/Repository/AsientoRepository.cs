using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Interfaces;
using BoletoBus.Domain.Models;
using BoletoBus.Infraestructure.Context;
using BoletoBus.Infraestructure.Core;
using Microsoft.EntityFrameworkCore;

namespace BoletoBus.Infraestructure.Repository
{
    public class AsientoRepository : BaseRepository<Asiento>, IAsientoRepository
    {

        public void TestConnection()
        {
            this.context.Database.OpenConnection();
            this.context.Database.CloseConnection();
        }


        private readonly BoletoBusContext context;
        public AsientoRepository(BoletoBusContext context) : base(context)
        {
            this.context = context;
        }

        public List<AsientoModel> GetAsientos()
        {
            var asientos = (from a in context.Asiento
                            join b in context.Bus on a.IdBus equals b.IdBus
                            where a.Deleted == false
                            select new AsientoModel
                            {
                                NumeroAsiento = a.NumeroAsiento,
                                NumeroPiso = a.NumeroPiso,

                                Bus = new BusModel
                                {
                                    NumeroPlaca = b.NumeroPlaca,
                                    Nombre = b.Nombre,
                                    Disponible = b.Disponible

                                },
                                ReservaDetalles = (from rd in context.ReservaDetalle
                                                   where rd.IdAsiento == a.IdAsiento
                                                   select new ReservaDetalleModel
                                                   {
                                                       IdReserva = rd.IdReserva,
                                                       IdAsiento = rd.IdAsiento

                                                   }).ToList()
                            }).ToList();

            return asientos;
        }

        public List<AsientoModel> GetAsientosByBus(int busId)
        {
            var asientos = (from a in context.Asiento
                            join b in context.Bus on a.IdBus equals b.IdBus
                            where a.Deleted == false && a.IdBus == busId
                            select new AsientoModel
                            {
                                NumeroAsiento = a.NumeroAsiento,
                                NumeroPiso = a.NumeroPiso,

                                Bus = new BusModel
                                {
                                    NumeroPlaca = b.NumeroPlaca,
                                    Nombre = b.Nombre,
                                    Disponible = b.Disponible

                                },
                                ReservaDetalles = (from rd in context.ReservaDetalle
                                                   where rd.IdAsiento == a.IdAsiento
                                                   select new ReservaDetalleModel
                                                   {
                                                       IdReserva = rd.IdReserva,
                                                       IdAsiento = rd.IdAsiento

                                                   }).ToList()
                            }).ToList();

            return asientos;
        }

    }
}
