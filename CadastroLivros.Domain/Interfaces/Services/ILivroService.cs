using CadastroLivros.Domain.Entities;
using System.Collections.Generic;

namespace CadastroLivros.Domain.Interfaces.Services
{
    public interface ILivroService
    {
        IEnumerable<Livro> GetAll();
        Livro GetById(int id);
        void Add(Livro obj);
        void Update(Livro obj);
        void Remove(Livro obj);
    }
}
