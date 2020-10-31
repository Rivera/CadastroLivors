using System.Collections.Generic;

namespace CadastroLivros.Domain.Entities
{
    public class Autor : BaseEntity
    {
        public string Nome { get; set; }
        public virtual IEnumerable<Livro> Livros { get; set; }
    }
}
