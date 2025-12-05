using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CrudMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{
    public class teste : Controller
    {
        private readonly ILogger<teste> _logger;

        public static List<Aluno> ListadeAlunos = new List<Aluno>
        {
            new Aluno{},
        };

        public teste(ILogger<teste> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Listar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Excluir()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}