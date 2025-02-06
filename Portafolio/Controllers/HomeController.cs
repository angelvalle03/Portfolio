using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoryProjects _repositoryProjects;

        public HomeController(ILogger<HomeController> logger, IRepositoryProjects repositoryProjects)
        {
            _logger = logger;
            _repositoryProjects = repositoryProjects;
        }

        public IActionResult Index()
        {
            //var person = new Person()
            //{
            //    Name = "Angel De Jesus Valle",
            //    Age = 24
            //};
            //ViewBag.Name = "Angel De Jesus Valle";
            _logger.LogInformation("This is an information log");
            var repositoryProjetcs = _repositoryProjects;
            var projects = repositoryProjetcs.GetProjects().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Projects = projects };
            return View(modelo);
        }

        

        public IActionResult Projects()
        { 
        
            var projects = _repositoryProjects.GetProjects();
            return View(projects);
        
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel ContactViewModel)
        {
            return RedirectToAction("Thanks");
        }

        public IActionResult Thanks()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}