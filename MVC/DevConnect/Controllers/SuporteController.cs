using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevConnect.Controllers
{
    [Route("[controller]")]
    public class SuporteController : Controller
    {
        private readonly ILogger<SuporteController> _logger;

        public SuporteController(ILogger<SuporteController> logger)
        {
            _logger = logger;
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