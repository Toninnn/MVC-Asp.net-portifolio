using Microsoft.AspNetCore.Mvc;
using MVC_Asp.net_portifolio.Models;
using System.Diagnostics;

namespace MVC_Asp.net_portifolio.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
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
