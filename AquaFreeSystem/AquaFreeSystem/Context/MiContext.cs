using Microsoft.EntityFrameworkCore;

namespace AquaFreeSystem.Context
{
    public class MiContext : DbContext
    {
        public MiContext(DbContextOptions<MiContext> options) : base(options)
        {
        }
        public DbSet<Models.Usuario> Usuarios { get; set; }
    }
}
