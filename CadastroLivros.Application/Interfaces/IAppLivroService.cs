using CadastroLivros.Domain.Entities;
using System.Collections.Generic;

namespace CadastroLivros.Application.Interfaces
{
    public interface IAppLivroService
    {
        IEnumerable<Livro> GetAll();
        Livro GetById(int id);
        void Add(Livro obj);
        void Update(Livro obj);
        void Remove(Livro obj);
    }
}
