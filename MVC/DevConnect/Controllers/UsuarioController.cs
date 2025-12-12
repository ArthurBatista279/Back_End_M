using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevConnect.Contexts;
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevConnect.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        private readonly DevConnectContext _context;

        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]

        public IActionResult Cadastro()
        {
            ViewBag.MensagemSucesso = "";
            TempData["MensagemSucesso"] = "";
            return View();
        }

        [HttpPost]

        public IActionResult Perfil()
        {
            return View();
        }
        public async Task<IActionResult> Cadastro(IFormCollection form)
        {
            TbUsuario novoUsuario = new TbUsuario()
            {
                NomeCompleto = form["NomeCompleto"].ToString(),
                NomeUsuario = form["NomeUsuario"].ToString(),
                Email = form["Email"].ToString()
            };

            if (form.Files.Count > 0)
            {
                //se selecionou uma imagem entra dentro do if
                IFormFile file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string path = Path.Combine(folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                    novoUsuario.FotoPerfilUrl = file.FileName;
                }
            }
            else
            {
                novoUsuario.FotoPerfilUrl = "";
            }

            try
            {
                _context.TbUsuario.Add(novoUsuario);
                await _context.SaveChangesAsync();
                TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";
                ViewBag.MensagemSucesso = "";

                return RedirectToAction("Index", "Home");
            }
            catch (System.Exception)
            {
                ViewBag.MensagemSucesso = "Não foi possível cadastrar o usuário.";
                TempData["MensagemSucesso"] = "";
                throw;
            }

        }
        public IActionResult Suporte()
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