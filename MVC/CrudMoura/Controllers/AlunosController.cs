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
    public class AlunosController : Controller
    {
        private readonly ILogger<AlunosController> _logger;

        public static List<Aluno> ListaAluno = new List<Aluno>
        {
            new Aluno{Id = 1, Nome = "Arthur", Idade = 18, Ra = 1117511571, CPF = 545343618-23, Turma = "Segundo Ano (Ensino Medio)"}
        };

        public AlunosController(ILogger<AlunosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarAluno()
        {
            ViewBag.Aluno = ListaAluno;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult SalvarAluno(Aluno alunocadastro)
        {
            ListaAluno.Add(alunocadastro);

            return RedirectToAction(nameof(ListaAluno));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}