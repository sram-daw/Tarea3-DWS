using Microsoft.AspNetCore.Mvc;
using RamiloAlonsoSaraTarea3.Models;

namespace RamiloAlonsoSaraTarea3.Controllers
{
    public class LoginsController : Controller
    {
        private readonly LoginsContext _context;
        public LoginsController(LoginsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> checkLogin(string user, string pwd)
        {
            var manager = new LoginManager(_context);
            var login = manager.GetLoginByUserPwd(user, pwd);
            if (login != null) {
                return RedirectToAction("Index", "Home");
            }
            else {
                TempData["ErrorMessage"] = "Los datos introducidos no son correctos.";
                return View("Index");
            }
        }
    }
}
