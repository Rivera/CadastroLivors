using CadastroLivros.Application.Interfaces;
using CadastroLivros.Domain.Entities;
using CadastroLivros.Domain.Interfaces.Repositories;
using CadastroLivros.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CadastroLivros.Application
{
    public class AppAssuntoService : IAppAssuntoService
    {
        private readonly IAssuntoService _service;

        public AppAssuntoService(IAssuntoService service)
        {
            _service = service;
        }

        public void Add(Assunto obj)
        {
            _service.Add(obj);
        }

        public IEnumerable<Assunto> GetAll()
        {
            return _service.GetAll();
        }

        public Assunto GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Remove(Assunto obj)
        {
            _service.Remove(obj);
        }

        public void Update(Assunto obj)
        {
            _service.Update(obj);
        }
    }
}
