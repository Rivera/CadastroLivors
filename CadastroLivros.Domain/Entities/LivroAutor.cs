namespace CadastroLivros.Domain.Entities
{
    public class LivroAutor
    {
        public int LivroId { get; set; }
        public int AutorId { get; set; }

        public virtual Livro Livro { get; set; }
        public virtual Autor Autor { get; set; }
    }
}
