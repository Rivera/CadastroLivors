using CadastroLivros.Application.Interfaces;
using CadastroLivros.Domain.Entities;
using CadastroLivros.Domain.Interfaces.Repositories;
using CadastroLivros.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CadastroLivros.Application
{
    public class AppLivroService : IAppLivroService
    {
        private readonly ILivroService _service;

        public AppLivroService(ILivroService service)
        {
            _service = service;
        }

        public void Add(Livro obj)
        {
            _service.Add(obj);
        }

        public IEnumerable<Livro> GetAll()
        {
            return _service.GetAll();
        }

        public Livro GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Remove(Livro obj)
        {
            _service.Remove(obj);
        }

        public void Update(Livro obj)
        {
            _service.Update(obj);
        }
    }
}
