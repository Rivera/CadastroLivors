using System.Collections.Generic;

namespace CadastroLivros.Domain.Entities
{
    public class Assunto : BaseEntity
    {
        public Assunto()
        {
            this.Livros = new HashSet<Livro>();
        }
        public string Descricao { get; set; }
        public virtual IEnumerable<Livro> Livros { get; set; }
    }
}
