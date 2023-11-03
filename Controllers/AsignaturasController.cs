using Microsoft.AspNetCore.Mvc;
using RamiloAlonsoSaraTarea3.Models;

namespace RamiloAlonsoSaraTarea3.Controllers
{
    public class AsignaturasController : Controller
    {
        private readonly AsignaturasContext _context;
        public AsignaturasController(AsignaturasContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var manager = new AsignaturasManager(_context);
            var asignaturas = manager.GetAllAsignaturas();
            return View(asignaturas);
        }

        public IActionResult Detalles(int id)
        {
            var manager = new AsignaturasManager(_context);
            var asignatura = manager.GetAsignaturaByID(id);
            return View(asignatura);
        }
    }
}
