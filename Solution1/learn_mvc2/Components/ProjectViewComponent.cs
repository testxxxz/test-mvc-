using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using learn_mvc2.Models;

namespace MyApp.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {


            List<Project> projects = new List<Project> {

            new Project {image="~/assets/images/project/project-1.jpg",client="google",text="Project intro lorem ipsum dolor sit amet, consectetuer\r\n\t\t\t\t\t\t\t\t\tadipiscing elit. Cum sociis natoque penatibus et magnis dis parturient\r\n\t\t\t\t\t\t\t\t\tmontes."},
            new Project {image="~/assets/images/project/project-2.jpg",client="Dropbox",text="\tLorem ipsum dolor sit amet, consectetuer adipiscing elit.\r\n\t\t\t\t\t\t\t\t\tCum sociis natoque penatibus et magnis dis parturient montes, nascetur\r\n\t\t\t\t\t\t\t\t\tridiculus mus."}
            };


            return View( projects); 
        }
    }
}
