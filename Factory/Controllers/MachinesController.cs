using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Machine> model = _db.Machines
                            .ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      Machine thisMachine = _db.Machines
          .Include(Machine => Machine.JoinEntities)
          .ThenInclude(join => join.Engineer)
          .FirstOrDefault(Machine => Machine.MachineId == id);
      return View(thisMachine);
    }
  }
}