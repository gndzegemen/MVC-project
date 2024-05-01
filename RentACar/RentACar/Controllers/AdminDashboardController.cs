using Microsoft.AspNetCore.Mvc;
using RentACar_DataAccess.Data;
using RentACar_Model.Models;

namespace RentACar.Controllers
{
    public class AdminDashboardController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminDashboardController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Vehicle> objList = _db.vehicles.ToList();

            return View(objList);
        }

        [HttpGet]
        public IActionResult AddNewVehicle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewVehicle(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _db.vehicles.Add(vehicle);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }

        [HttpGet]
        public IActionResult VehicleChart(int id)
        {
            var vehicle = _db.vehicles.Find(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            var chartData = new Dictionary<string, int>
            {
                { "Active Working Time", Convert.ToInt32(vehicle.ActiveWorkingTime) },
                { "Idle Standby Time", Convert.ToInt32(vehicle.IdleStandbyTime) },
                { "Maintenance Time", Convert.ToInt32(vehicle.MaintenanceTime) }
            };


            return View(chartData);
        }

    }
}
