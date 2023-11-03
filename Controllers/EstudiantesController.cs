using Microsoft.AspNetCore.Mvc;
using RamiloAlonsoSaraTarea3.Models;

namespace RamiloAlonsoSaraTarea3.Controllers
{
    public class EstudiantesController : Controller
    {
        private readonly EstudiantesContext _context;
        public EstudiantesController(EstudiantesContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var manager = new EstudiantesManager(_context);
            var estudiantes = manager.GetAllEstudiantes();
            return View(estudiantes);
        }

        public IActionResult Detalles(int id)
        {
            var manager = new EstudiantesManager(_context);
            var estudiante = manager.GetEstudianteByID(id);
            return View(estudiante);
        }
    }
}
