using Microsoft.AspNetCore.Mvc;
using Palavras.Models;
using Palavras.Repository;
using System.Diagnostics;

namespace Palavras.Controllers
{
    public class PalavraController : Controller
    {
        private readonly IPalavraRepository _palavraRepository;

        public PalavraController(PalavraRepository palavraRepository)
        {
           _palavraRepository = palavraRepository;
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
