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

  }

}