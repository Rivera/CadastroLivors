using CadastroLivros.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CadastroLivros.Infra.Data.EntityConfig
{
    public class AssuntoConfiguration : EntityTypeConfiguration<Assunto>
    {
        public AssuntoConfiguration()
        {
            HasKey(s => s.Id);

            Property(s => s.Descricao)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}