using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Factory.Models;

namespace Factory.Controllers
{
  public class LocationsController : Controller
  {
    private readonly FactoryContext _db;

    public LocationsController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Location> model = _db.Locations.ToList();
          // model.Add(new Location { Facility = "NE", LocationId = 1});
          // model.Add(new Location { Facility = "SE", LocationId = 2});
          // model.Add(new Location { Facility = "SW", LocationId = 3});
      return View(model);
    }

    public ActionResult Details(int id)
    {
      var thisLocation = _db.Locations
          .Include(location => location.Engineers)
          .ThenInclude(join => join.Engineer)
          .FirstOrDefault(location => location.LocationId == id);
      return View(thisLocation);
    }

    // public ActionResult AddEngineer(int id) 
    // {
    //   var thisLocation = _db.Locations.FirstOrDefault(location => location.LocationId == id);
    //   ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
    //   return View(thisLocation);
    // }

    // [HttpPost]
    // public ActionResult AddEngineer(Machine machine, int EngineerId)
    // {
    //   if (EngineerId != 0)
    //   {
    //     _db.MachineEngineer.Add(new MachineEngineer() { EngineerId = EngineerId, MachineId = machine.MachineId });
    //   }
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    
  }
}