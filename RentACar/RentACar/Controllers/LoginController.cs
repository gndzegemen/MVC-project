using Microsoft.AspNetCore.Mvc;
using RentACar_DataAccess.Data;
using RentACar_Model.Models;

namespace RentACar.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Kullanıcı adı ve şifre kontrolü
            var user = _db.users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null)
            {
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View("Index");
            }

            // Kullanıcı rolüne göre yönlendirme
            switch (user.UserRole)
            {
                case Role.Admin:
                    return RedirectToAction("Index", "AdminDashboard"); // Admin sayfasına yönlendirme
                case Role.User:
                    return RedirectToAction("Index", "UserDashboard"); // Kullanıcı sayfasına yönlendirme
                default:
                    return RedirectToAction("Index");
            }
        }
    }
}
