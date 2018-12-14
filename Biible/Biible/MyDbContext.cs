using System;
using Biible.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Biible
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Curiosidade> Curiosidades { get; set; }
        public DbSet<Genealogia> Genealogias { get; set; }
        public DbSet<Outro_Nome> Outros_Nomes { get; set; }
        public DbSet<PassagemBiblica> Passages_Biblicas { get; set; }
        public DbSet<Referencia> Referencias { get; set; }
        public DbSet<Regiao> Regioes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=;Database=dbbiible");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
