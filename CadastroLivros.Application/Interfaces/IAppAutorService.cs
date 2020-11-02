using CadastroLivros.Domain.Entities;
using System.Collections.Generic;

namespace CadastroLivros.Application.Interfaces
{
    public interface IAppAutorService
    {
        IEnumerable<Autor> GetAll();
        Autor GetById(int id);
        void Add(Autor obj);
        void Update(Autor obj);
        void Remove(Autor obj);
    }
}
