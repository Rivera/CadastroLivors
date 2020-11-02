using CadastroLivros.Domain.Entities;
using CadastroLivros.Domain.Interfaces.Repositories;
using CadastroLivros.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CadastroLivros.Domain.Services
{
    public class LivroService : ILivroService
    {
        public readonly IBaseRepository<Livro> _repository;

        public LivroService(IBaseRepository<Livro> repository)
        {
            _repository = repository;
        }

        public void Add(Livro obj)
        {
            _repository.Add(obj);
        }

        public IEnumerable<Livro> GetAll()
        {
            return _repository.GetAll();
        }

        public Livro GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(Livro obj)
        {
            _repository.Remove(obj);
        }

        public void Update(Livro obj)
        {
            _repository.Update(obj);
        }
    }
}
