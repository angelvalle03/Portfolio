using Microsoft.AspNetCore.Mvc;

namespace Portafolio.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Project()
        {
            return View();
        }
    }
}
