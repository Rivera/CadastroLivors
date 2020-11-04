using System.Collections.Generic;

namespace CadastroLivros.Domain.Entities
{
    public class Livro : BaseEntity
    {
        public Livro()
        {
            this.Autores = new HashSet<Autor>();
            this.Assuntos = new HashSet<Assunto>();
        }

        public string Titulo { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
        public string AnoPublicacao { get; set; }
        public double Valor { get; set; }
        public virtual ICollection<Autor> Autores { get; set; }
        public virtual ICollection<Assunto> Assuntos { get; set; }
    }
}
