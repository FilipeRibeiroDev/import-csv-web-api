using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }


        /// <summary>
        /// Adicionar produtos em lote
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("batch")]
        public async Task<IActionResult> Add(IFormFile file)
        {
            await _service.Add(file);
            return Ok();
        }
    }
}
