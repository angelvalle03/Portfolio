using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
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
            //var repositoryProjetcs = _repositoryProjects;
            //var projects = repositoryProjetcs.GetProjects().Take(3).ToList();
            //var modelo = new HomeIndexViewModel() { Projects = projects };
            return View();
        }


        
    }
}