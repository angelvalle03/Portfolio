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
                Title= "Amazon",
                Description = "E-Commerce realizado en ASP.NEt",
                Link = "https://amazon.com",
                ImageURL = "/Images/images.png"

            },
            new Project
            {
                Title= "New York Time",
                Description = "News pagen using react",
                Link = "https://amazon.com",
                ImageURL = "/Images/images.png"

            },
            new Project
            {
                Title= "Google",
                Description = "Implement adjustme for pages using .NET",
                Link = "https://google.com",
                ImageURL = "/Images/images.png"

            },
            new Project
            {
                Title= "Apple",
                Description = "Creation of section for web page using react",
                Link = "https://apple.com",
                ImageURL = "/Images/images.png"

            }
            };
        }
    }
}
