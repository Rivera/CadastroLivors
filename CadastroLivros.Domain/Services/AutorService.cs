using CadastroLivros.Domain.Entities;
using CadastroLivros.Domain.Interfaces.Repositories;
using CadastroLivros.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CadastroLivros.Domain.Services
{
    public class AutorService : IAutorService
    {
        public readonly IBaseRepository<Autor> _repository;

        public AutorService(IBaseRepository<Autor> repository)
        {
            _repository = repository;
        }

        public void Add(Autor obj)
        {
            _repository.Add(obj);
        }

        public IEnumerable<Autor> GetAll()
        {
            return _repository.GetAll();
        }

        public Autor GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(Autor obj)
        {
            _repository.Remove(obj);
        }

        public void Update(Autor obj)
        {
            _repository.Update(obj);
        }
    }
}
