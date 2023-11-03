using Microsoft.EntityFrameworkCore;

namespace RamiloAlonsoSaraTarea3.Models
{
    public class AsignaturasContext : DbContext
    {
        public AsignaturasContext(DbContextOptions<AsignaturasContext> options) : base(options) { }
        public DbSet<Asignaturas> Asignaturas { get; set; }
    }
}
