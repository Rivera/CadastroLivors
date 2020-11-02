using CadastroLivros.Domain.Entities;
using System.Collections.Generic;

namespace CadastroLivros.Domain.Interfaces.Services
{
    public interface IAssuntoService
    {
        IEnumerable<Assunto> GetAll();
        Assunto GetById(int id);
        void Add(Assunto obj);
        void Update(Assunto obj);
        void Remove(Assunto obj);
    }
}
