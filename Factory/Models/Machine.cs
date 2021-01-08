using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<MachineEngineer>();
      State = "operational";
    }

    public int MachineId { get; set; }
    public string Model { get; set; }
    public string State { get; set; }
    

    public ICollection<MachineEngineer> Engineers { get; set; }
  }
}