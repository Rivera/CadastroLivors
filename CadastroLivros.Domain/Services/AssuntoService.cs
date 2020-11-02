using CadastroLivros.Domain.Entities;
using CadastroLivros.Domain.Interfaces.Repositories;
using CadastroLivros.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CadastroLivros.Domain.Services
{
    public class AssuntoService : IAssuntoService
    {
        private readonly IBaseRepository<Assunto> _repository;

        public AssuntoService(IBaseRepository<Assunto> repository)
        {
            _repository = repository;
        }

        public void Add(Assunto obj)
        {
            _repository.Add(obj);
        }

        public IEnumerable<Assunto> GetAll()
        {
            return _repository.GetAll();
        }

        public Assunto GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(Assunto obj)
        {
            _repository.Remove(obj);
        }

        public void Update(Assunto obj)
        {
            _repository.Update(obj);
        }
    }
}
