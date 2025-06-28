using avaliacoes_service.Data;
using avaliacoes_service.Models.Entities;
using avaliacoes_service.Repositories.Interfaces;

namespace avaliacoes_service.Repositories
{
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        private readonly AppDbContext _context;

        public AvaliacaoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Avaliacao> AddAsync(Avaliacao avaliacao)
        {
            _context.Avaliacoes.Add(avaliacao);
            await _context.SaveChangesAsync();
            return avaliacao;
        }
        /*
        public async Task<IEnumerable<Avaliacao>> GetByEventoIdAsync(int eventoId)
        {
            return await _context.Avaliacoes
                .Where(a => a.EventoId == eventoId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Avaliacao>> GetByPalestranteIdAsync(int palestranteId)
        {
            return await _context.Avaliacoes
                .Where(a => a.PalestranteId == palestranteId)
                .ToListAsync();
        }

        public async Task<Avaliacao?> UpdateAsync(Avaliacao avaliacao)
        {
            _context.Avaliacoes.Update(avaliacao);
            await _context.SaveChangesAsync();
            return avaliacao;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var avaliacao = await _context.Avaliacoes.FindAsync(id);
            if (avaliacao == null) return false;
            _context.Avaliacoes.Remove(avaliacao);
            await _context.SaveChangesAsync();
            return true;
        }*/
    }

}
