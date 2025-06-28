using avaliacoes_service.Models.DTOs;
using avaliacoes_service.Models.Entities;
using avaliacoes_service.Repositories.Interfaces;

namespace avaliacoes_service.Services
{
    public class AvaliacaoService
    {
        private readonly IAvaliacaoRepository _repository;

        public AvaliacaoService(IAvaliacaoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Avaliacao> CriarAvaliacaoAsync(CreateAvaliacaoDTO dto)
        {
            var avaliacao = new Avaliacao
            {
                EventoId = dto.EventoId,
                PalestranteId = dto.PalestranteId,
                UsuarioId = dto.UsuarioId,
                Pontuacao = dto.Pontuacao,
                Comentario = dto.Comentario,
                Data = DateTime.UtcNow
            };

            return await _repository.AddAsync(avaliacao);
        }
    }
}
