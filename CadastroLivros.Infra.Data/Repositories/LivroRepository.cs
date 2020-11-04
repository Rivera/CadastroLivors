using CadastroLivros.Domain.Entities;
using CadastroLivros.Domain.Interfaces.Repositories;
using System.Linq;

namespace CadastroLivros.Infra.Data.Repositories
{
    public class LivroRepository : BaseRepository<Livro>, ILivroRepository
    {

    }
}
