using Microsoft.AspNetCore.Mvc;
using MVC_Asp.net_portifolio.Models;
using System.Diagnostics;

namespace MVC_Asp.net_portifolio.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Nome = "Antonio neto";
            home.Email = "antonio@gmail.com";
            
            return View(home);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Apagar()
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
