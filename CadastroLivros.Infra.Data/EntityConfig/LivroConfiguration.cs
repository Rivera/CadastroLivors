using CadastroLivros.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CadastroLivros.Infra.Data.EntityConfig
{
    public class LivroConfiguration : EntityTypeConfiguration<Livro>
    {
        public LivroConfiguration()
        {
            HasKey(l => l.Id);

            Property(l => l.Titulo)
                .IsRequired()
                .HasMaxLength(40);

            Property(l => l.Editora)
                .IsRequired()
                .HasMaxLength(40);

            Property(l => l.Edicao)
                .IsRequired();

            Property(l => l.AnoPublicacao)
                .IsRequired()
                .HasMaxLength(4);
        }
    }
}
