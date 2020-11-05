using CadastroLivros.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CadastroLivros.Infra.Data.EntityConfig
{
    public class AutorConfiguration : EntityTypeConfiguration<Autor>
    {
        public AutorConfiguration()
        {
            HasKey(a => a.Id);

            Property(a => a.Nome)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}