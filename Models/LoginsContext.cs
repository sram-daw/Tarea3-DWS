using Microsoft.EntityFrameworkCore;

namespace RamiloAlonsoSaraTarea3.Models
{
    public class LoginsContext : DbContext
    {
        public LoginsContext(DbContextOptions<LoginsContext> options) : base(options) { }
        public DbSet<Logins> Logins { get; set; }
    }
}
