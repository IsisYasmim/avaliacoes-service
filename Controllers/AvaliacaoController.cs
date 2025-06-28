using avaliacoes_service.Models.DTOs;
using avaliacoes_service.Models.Entities;
using avaliacoes_service.Services;
using Microsoft.AspNetCore.Mvc;

namespace avaliacoes_service.Controllers
{
    [ApiController]
    [Route("api/avaliacoes")]
    public class AvaliacaoController : ControllerBase
    {
        private readonly AvaliacaoService _service;

        public AvaliacaoController(AvaliacaoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<Avaliacao>> Post([FromBody] CreateAvaliacaoDTO dto)
        {
            var avaliacao = await _service.CriarAvaliacaoAsync(dto);
            return CreatedAtAction(nameof(Post), new { id = avaliacao.Id }, avaliacao);
        }

    }
}
