using BoletoBus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace BoletoBus.Infraestructure.Context
{
    public partial class BoletoBusContext : DbContext
    {
        public BoletoBusContext(DbContextOptions<BoletoBusContext> dbContext) : base(dbContext)
        {

        }
        public DbSet<Asiento> Asiento { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<ReservaDetalle> ReservaDetalle { get; set; }
        public DbSet<Ruta> Ruta { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Viaje> Viaje { get; set; }

    }
}
