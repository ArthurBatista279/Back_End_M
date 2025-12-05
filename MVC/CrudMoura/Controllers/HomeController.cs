using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

  //ação padrão inicial

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Minhaacao()
    {
        return View(); //retorne na pagina Minhaacao.cshtml
    }
    
    public IActionResult ListarNomes()
    {
        string[] nomes = {"Cauhê", "Anel", "Barney", "Salgado", "Ronaldo"};
        ViewBag.Nomes = nomes; //guarda os nomes na viewbag
        ViewBag.Teste = "Olá, eu caguei nas calças";
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
