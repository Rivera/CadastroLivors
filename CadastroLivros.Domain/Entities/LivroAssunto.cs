namespace CadastroLivros.Domain.Entities
{
    public class LivroAssunto
    {
        public int LivroId { get; set; }
        public int AssuntoId { get; set; }

        public virtual Livro Livro { get; set; }
        public virtual Assunto Assunto { get; set; }
    }
}
