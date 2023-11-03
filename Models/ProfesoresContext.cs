using Microsoft.EntityFrameworkCore;

namespace RamiloAlonsoSaraTarea3.Models
{
    public class ProfesoresContext : DbContext
    {
        public ProfesoresContext(DbContextOptions<ProfesoresContext> options) : base(options) { }
        public DbSet<Profesores> Profesores { get; set; }
    }
}
