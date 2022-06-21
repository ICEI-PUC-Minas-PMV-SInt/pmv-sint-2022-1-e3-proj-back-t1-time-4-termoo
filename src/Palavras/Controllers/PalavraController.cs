using Microsoft.AspNetCore.Mvc;
using Palavras.Models;
using System.Diagnostics;

namespace Palavras.Controllers
{
    public class PalavraController : Controller
    {
        private readonly ILogger<PalavraController> _logger;

        public PalavraController(ILogger<PalavraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RetornaPalavra()
        {
            return Ok();
        }
    }
}
