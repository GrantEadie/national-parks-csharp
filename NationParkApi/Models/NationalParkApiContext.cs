using Microsoft.EntityFrameworkCore;

namespace NationalParkApi.Models
{
  public class NationalParkApiContext : DbContext
  {
    public NationalParkApiContext(DbContextOptions<NationalParkApiContext> options) : base(options)
    {
    }
    public virtual DbSet<State> States { get; set; }
    public virtual DbSet<Reserve> Reserves { get; set; }
    public DbSet<StateReserve> StateReserves { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<State>()
        .HasData(
          new State { StateId = 1, StateName = "Washington"},
          new State { StateId = 2, StateName = "Oregon"},
          new State { StateId = 3, StateName = "Utah"},
          new State { StateId = 4, StateName = "California"},
          new State { StateId = 5, StateName = "Montana"}
      );
      builder.Entity<Reserve>()
        .HasData(
          new Reserve { ReserveId = 1, ReserveName = "North Cascades National Park"},
          new Reserve { ReserveId = 2, ReserveName = "Mt. Hood NationalForest"},
          new Reserve { ReserveId = 3, ReserveName = "Zion National Park"},
          new Reserve { ReserveId = 4, ReserveName = "Yosemite National Park"},
          new Reserve { ReserveId = 5, ReserveName = "Yellowstone National Park"}
      );
      builder.Entity<StateReserve>()
        .HasData(
          new StateReserve { StateReserveId = 1, StateId = 1, ReserveId = },
          new StateReserve { StateReserveId = 2, StateId = "Mt. Hood NationalForest"},
          new StateReserve { StateReserveId = 3, StateId = "Zion National Park"},
          new StateReserve { StateReserveId = 4, StateId = "Yosemite National Park"},
          new StateReserve { StateReserveId = 5, StateId = "Yellowstone National Park"}
      );
    }
  }
}