using CadastroLivros.Domain.Entities;
using CadastroLivros.Domain.Interfaces.Repositories;
using System.Linq;

namespace CadastroLivros.Infra.Data.Repositories
{
    public class LivroRepository : BaseRepository<Livro>, ILivroRepository
    {
        public LivroRepository()
        {

        }

        public Livro GetLivroByName(string nome)
        {
            return Db.Livros.FirstOrDefault(x => x.Titulo == nome);
        }
    }
}
