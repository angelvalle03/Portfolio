using Microsoft.AspNetCore.Mvc;
using Portafolio.Services;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class ProjectController : Controller
    {

        private readonly IRepositoryProjects _repositoryProjects;

        public ProjectController(IRepositoryProjects repositoryProjects)
        {
            _repositoryProjects = repositoryProjects;
        }

        public IActionResult Project()
        {

            var projects = _repositoryProjects.GetProjects();
            return View(projects);
        }
    }
}
