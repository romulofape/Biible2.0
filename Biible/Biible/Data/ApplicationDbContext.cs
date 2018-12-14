using Biible.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Biible.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Curiosidade> Curiosidades { get; set; }
        public DbSet<Genealogia> Genealogias { get; set; }
        public DbSet<Outro_Nome> Outros_Nomes { get; set; }
        public DbSet<PassagemBiblica> Passages_Biblicas { get; set; }
        public DbSet<Referencia> Referencias { get; set; }
        public DbSet<Regiao> Regioes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
