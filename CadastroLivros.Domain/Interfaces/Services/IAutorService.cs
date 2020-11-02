using CadastroLivros.Domain.Entities;
using System.Collections.Generic;

namespace CadastroLivros.Domain.Interfaces.Services
{
    public interface IAutorService
    {
        IEnumerable<Autor> GetAll();
        Autor GetById(int id);
        void Add(Autor obj);
        void Update(Autor obj);
        void Remove(Autor obj);
    }
}
