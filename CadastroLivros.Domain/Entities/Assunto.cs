using System.Collections.Generic;

namespace CadastroLivros.Domain.Entities
{
    public class Assunto : BaseEntity
    {
        public string Descricao { get; set; }
        public virtual ICollection <Livro> Livros { get; set; }
    }
}
