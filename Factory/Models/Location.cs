using System.Collections.Generic;

namespace Factory.Models
{
  public class Location
  {
    public Location()
    {
      this.Engineers = new HashSet<EngineerLocation>();
    }

    public int LocationId { get; set; }
    public string Location { get; set; }

    public ICollection<EngineerLocation> Engineers { get; set; }
  }
}