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

    }
}
