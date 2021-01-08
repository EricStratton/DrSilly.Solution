using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<Machine> Machines { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Location> Locations { get; set; }

    public DbSet<MachineEngineer> MachineEngineer { get; set; }
    public DbSet<EngineerLocation> EngineerLocation { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}