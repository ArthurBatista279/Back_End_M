using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers
{
    public class Frutas : Controller
    {
        private readonly ILogger<Frutas> _logger;

        public static List<Fruta> ListadeFrutas = new List<Fruta>
        {

            new Fruta{ID = 1, Nome = "Abacaxi", Preco = 6.99f, Quantidade = 10, Categoria = "Tropical"},
            new Fruta{ID = 2, Nome = "Morango", Preco = 4.99f, Quantidade = 7, Categoria = "Tropical"},
            new Fruta{ID = 3, Nome = "Limão", Preco = 1.98f, Quantidade = 2, Categoria = "Cítrica"},
            
        };

        public Frutas(ILogger<Frutas> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarFrutas()
        {
            ViewBag.frutas = ListadeFrutas;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        
        //Ao salvar irá redirecionar para a listagem de frutas
        [HttpPost]
        public IActionResult Salvar(Fruta frutaCadastrada)
        {
            frutaCadastrada.ID = ListadeFrutas.Max(f => f.ID) + 1;
            
            ListadeFrutas.Add(frutaCadastrada);

            return RedirectToAction(nameof (ListarFrutas));
        }   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!"); 
        }
    }
}