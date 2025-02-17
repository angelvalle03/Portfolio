using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IRepositoryProjects
    {
        List<Project> GetProjects();
    }
    public class RepositoryProjetcs : IRepositoryProjects
    {
        public List<Project> GetProjects()
        {
            return new List<Project>() {
            new Project
            {
                Title= "Servicios Navales del Caribe",
                Description = "Sitio web corporativo usando HTML, CSS y JavaScript",
                Link = "https://serviciosnavalesdelcaribe.com/",
                ImageURL = "/Images/Servicios-navales-Del-caribepage.png"

            },
            new Project
            {
                Title= "Portafolio personal",
                Description = "Portafolio hecho con ASP .Net y Blazor",
                Link = "https://amazon.com",
                ImageURL = "/Images/Portfolio-page.png"

            }
            };
        }
    }
}
