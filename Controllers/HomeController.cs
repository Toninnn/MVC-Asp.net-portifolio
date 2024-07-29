using Microsoft.AspNetCore.Mvc;
using MVC_Asp.net_portifolio.Models;
using MVC_Asp.net_portifolio.Repositorio;
using System.Diagnostics;

namespace MVC_Asp.net_portifolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public HomeController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

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
           
           List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
           return View(contatos);
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
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {   
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Contato");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
