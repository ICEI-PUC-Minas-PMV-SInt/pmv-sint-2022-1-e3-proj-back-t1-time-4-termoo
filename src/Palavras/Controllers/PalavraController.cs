using Microsoft.AspNetCore.Mvc;
using Palavras.Repository;
using System.Net;

namespace Palavras.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PalavraController : Controller
    {
        private readonly PalavraService _palavraService;

        public PalavraController(PalavraService palavraservice) => _palavraService = palavraservice;

        [HttpPost]
        public async Task<ActionResult> CriarPalavra(string palavra) 
        {
            if (palavra == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            await _palavraService.PostPalavra(palavra);

            return new HttpStatusCodeResult(HttpStatusCode.Accepted);
        }

        [HttpGet]
        public async Task<ActionResult> GetPalavra(string palavra) 
        {
            if (palavra == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            await _palavraService.GetPalavra();

            return new HttpStatusCodeResult(HttpStatusCode.Accepted);
        }
    }
}
