using CadastroLivros.Domain.Entities;
using System.Collections.Generic;

namespace CadastroLivros.Application.Interfaces
{
    public interface IAppAssuntoService
    {
        IEnumerable<Assunto> GetAll();
        Assunto GetById(int id);
        void Add(Assunto obj);
        void Update(Assunto obj);
        void Remove(Assunto obj);
    }
}
