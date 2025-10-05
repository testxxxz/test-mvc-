using System.Diagnostics;
using learn_mvc2.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.ContentModel;

namespace learn_mvc2.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {


            

    


            return View();
        }


        public IActionResult Contact()
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
