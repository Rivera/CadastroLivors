using CadastroLivros.Domain.Entities;
using CadastroLivros.Domain.Interfaces.Repositories;

namespace CadastroLivros.Infra.Data.Repositories
{
    public class LivroRepository : BaseRepository<Livro>, ILivroRepository
    {
    }
}
