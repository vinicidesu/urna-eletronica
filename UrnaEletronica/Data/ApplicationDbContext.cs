using Microsoft.EntityFrameworkCore;
using UrnaEletronica.Domain;

namespace UrnaEletronica.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Voto> Votos { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Candidato>()
                .Property(c => c.Legenda).IsRequired();
            builder.Entity<Candidato>()
                .Property(c => c.Nome).IsRequired();
            builder.Entity<Candidato>()
                .Property(c => c.NomeVice).IsRequired();
                
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configuration) 
        {
            configuration.Properties<string>()
                .HaveMaxLength(100);
        }
    }
}
