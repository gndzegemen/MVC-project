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

        public IActionResult Delete(int id)
        {
            var objDb = _db.vehicles.FirstOrDefault(a => a.VehicleId == id);
            _db.vehicles.Remove(objDb);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult ActiveWorkingTimeChart()
        {
            List<Vehicle> vehicles = _db.vehicles.ToList();
            Dictionary<string, int> chartData = new Dictionary<string, int>();

            foreach (var vehicle in vehicles)
            {
                chartData.Add(vehicle.Name, vehicle.ActiveWorkingTimePercentage);
            }

            return View(chartData);
        }

        [HttpGet]
        public IActionResult IdleStandbyTimeChart()
        {
            List<Vehicle> vehicles = _db.vehicles.ToList();
            Dictionary<string, int> chartData = new Dictionary<string, int>();

            foreach (var vehicle in vehicles)
            {
                chartData.Add(vehicle.Name, vehicle.IdleStandbyTimePercentage);
            }

            return View(chartData);
        }

    }
}
