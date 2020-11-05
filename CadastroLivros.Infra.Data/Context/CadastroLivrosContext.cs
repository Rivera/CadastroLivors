using CadastroLivros.Domain.Entities;
using CadastroLivros.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections.Generic;

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
        //public DbSet<LivroAutor> LivroAutores { get; set; }
        //public DbSet<LivroAssunto> LivroAssuntos { get; set; }

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

            modelBuilder.Entity<LivroAutor>().HasKey(la => new { la.AutorId, la.LivroId });

            modelBuilder.Entity<Autor>()
                .HasMany(la => la.Livros)
                .WithRequired()
                .HasForeignKey(la => la.Autores);

            modelBuilder.Entity<Assunto>()
                .HasMany(la => la.Livros)
                .WithRequired()
                .HasForeignKey(la => la.Assuntos);

            modelBuilder.Configurations.Add(new LivroConfiguration());
            modelBuilder.Configurations.Add(new AutorConfiguration());
            modelBuilder.Configurations.Add(new AssuntoConfiguration());
        }
    }
}
