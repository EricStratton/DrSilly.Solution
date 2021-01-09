using System.Collections.Generic;
using System.Linq;

namespace Factory.Models
{
  public class Location
  {
    public Location()
    {
      this.Engineers = new HashSet<EngineerLocation>();
    }

    public int LocationId { get; set; }
    public string Facility { get; set; }
    public List<SelectListLocation> ListLocation { get; set; }

    public ICollection<EngineerLocation> Engineers { get; set; }
  }
}