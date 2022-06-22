using Microsoft.AspNetCore.Mvc;
using Palavras.Models;
using Palavras.Repository;
using System.Diagnostics;
using System.Net;

namespace Palavras.Controllers
{
    public class PalavraController : Controller
    {
        private readonly IPalavraRepository _palavraRepository;

        public PalavraController(IPalavraRepository palavraRepository)
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

        [HttpPost]
        public async Task<ActionResult> CriarPalavra(string palavra) 
        {
            if (palavra == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            await _palavraRepository.PostPalavra(palavra);

            return View("Index");
        }
    }
}
