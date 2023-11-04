using Microsoft.AspNetCore.Mvc;
using RamiloAlonsoSaraTarea3.Models;

namespace RamiloAlonsoSaraTarea3.Controllers
{
    public class ProfesoresController : Controller
    {
        private readonly ProfesoresContext _context;
        public ProfesoresController(ProfesoresContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var manager = new ProfesoresManager(_context);
            var profesores = manager.GetAllProfesores();
            return View(profesores);
        }

        public IActionResult Detalles(int id)
        {
            var manager = new ProfesoresManager(_context);
            var profesor = manager.GetProfesorByID(id);
            return View(profesor);
        }
    }
}
