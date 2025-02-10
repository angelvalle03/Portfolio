using Microsoft.AspNetCore.Mvc;

namespace Portafolio.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Resume()
        {
            return View();
        }
    }
}
