using Microsoft.EntityFrameworkCore;

namespace RamiloAlonsoSaraTarea3.Models
{
    public class EstudiantesContext : DbContext
    {
        public EstudiantesContext(DbContextOptions<EstudiantesContext> options) : base(options) { }
        public DbSet<Estudiantes> Estudiantes { get; set; }

    }
}
