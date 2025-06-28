using avaliacoes_service.Models.Entities;

namespace avaliacoes_service.Repositories.Interfaces
{
    public interface IAvaliacaoRepository
    {
        Task<Avaliacao> AddAsync(Avaliacao avaliacao);
        /*Task<IEnumerable<Avaliacao>> GetByEventoIdAsync(int eventoId);
        Task<IEnumerable<Avaliacao>> GetByPalestranteIdAsync(int palestranteId);
        Task<Avaliacao?> UpdateAsync(Avaliacao avaliacao);
        Task<bool> DeleteAsync(int id);*/
    }
}
