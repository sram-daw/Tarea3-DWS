using Microsoft.AspNetCore.Mvc;
using RamiloAlonsoSaraTarea2.Models;

namespace RamiloAlonsoSaraTarea2.Controllers
{
    public class MiCurriculumController : Controller
    {
        public IActionResult MiCurriculum()
        {
            CurriculumModel perfil = new CurriculumModel();
            perfil = perfil.crearPerfil1();
            return View(perfil);
        }
    }
}
