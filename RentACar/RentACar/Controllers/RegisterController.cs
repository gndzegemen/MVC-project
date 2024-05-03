using Microsoft.AspNetCore.Mvc;
using RentACar_DataAccess.Data;
using RentACar_Model.Models;

namespace RentACar.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext _db;

        public RegisterController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _db.users.Add(user);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
    }
}
