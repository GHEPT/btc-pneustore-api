using Equipe2_PneuStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Equipe2_PneuStore.Data
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base (options) { }

        public DbSet<Tyre> Tyre { get; set; }

        public DbSet<Category> Category { get; set; }
        
        public DbSet<Partner> Partner { get; set; }
        
        public DbSet<Client> Client { get; set; }
        
        
    }
}
