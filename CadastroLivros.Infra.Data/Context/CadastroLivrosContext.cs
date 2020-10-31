using CadastroLivros.Domain.Entities;
using CadastroLivros.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CadastroLivros.Infra.Data.Context
{
    public class CadastroLivrosContext : DbContext
    {
        public CadastroLivrosContext() : base("CadastroLivrosConnection")
        {

        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Assunto> Assuntos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == "ID")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new LivroConfiguration());
            modelBuilder.Configurations.Add(new AutorConfiguration());
            modelBuilder.Configurations.Add(new AssuntoConfiguration());
        }
    }
}
