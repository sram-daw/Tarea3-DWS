using Microsoft.EntityFrameworkCore;

namespace RamiloAlonsoSaraTarea3.Models
{
    public class MatriculasContext : DbContext
    {
        public MatriculasContext(DbContextOptions<MatriculasContext> options) : base(options) { }
        public DbSet<Logins> Logins { get; set; }
    }
}
