using avaliacoes_service.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace avaliacoes_service.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Avaliacao> Avaliacoes { get; set; }
    }

}
