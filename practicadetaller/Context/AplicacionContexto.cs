using Microsoft.EntityFrameworkCore;
using practicadetaller.Models;

namespace practicadetaller.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto(DbContextOptions<AplicacionContexto>options): base(options) { }
        public DbSet<Disco> Disco { get; set; }
        public DbSet<Musica> Musica { get; set; }
    }
}
