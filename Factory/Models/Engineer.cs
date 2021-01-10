using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<MachineEngineer>();
      this.Locations = new HashSet<EngineerLocation>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<MachineEngineer> Machines { get; set; }
    public ICollection<EngineerLocation> Locations { get; set; }
  }
}