using Microsoft.AspNetCore.Mvc;
using RentACar_DataAccess.Data;
using RentACar_Model.Models;

namespace RentACar.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<User> objList = _db.users.ToList();

            return View(objList);
        }

        public IActionResult Delete(int id)
        {
            var objDb = _db.users.FirstOrDefault(a => a.UserId == id);
            _db.users.Remove(objDb);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
