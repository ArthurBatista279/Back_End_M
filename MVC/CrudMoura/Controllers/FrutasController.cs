using CrudMoura.Models;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;


namespace CrudMoura.Controllers
{
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public static List<Fruta> ListaDeFrutas = new List<Fruta>
        {
            new Fruta{Id = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10, Categoria = "Tropical"},
            new Fruta{Id = 2, Nome = "Abacate", Preco = 5.90f, Quantidade = 12, Categoria = "Tropical"},
            new Fruta{Id = 3, Nome = "Limao", Preco = 2.95f, Quantidade = 100, Categoria = "Citrica"},
        };

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListarFrutas()
        {
            ViewBag.Frutas = ListaDeFrutas;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult SalvarFruta(Fruta frutaCadastrada)
        {
            ListaDeFrutas.Add(frutaCadastrada);
            
            return RedirectToAction(nameof (ListarFrutas));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}