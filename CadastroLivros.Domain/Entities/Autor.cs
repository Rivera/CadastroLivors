using System.Collections.Generic;

namespace CadastroLivros.Domain.Entities
{
    public class Autor : BaseEntity
    {
        public Autor()
        {
            this.Livros = new HashSet<Livro>();
        }

        public string Nome { get; set; }
        public virtual IEnumerable<Livro> Livros { get; set; }
    }
}
