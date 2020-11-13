using CadastroLivros.Application.Interfaces;
using CadastroLivros.Domain.Entities;
using CadastroLivros.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CadastroLivros.Application
{
    public class AppAutorService : IAppAutorService
    {
        private readonly IAutorService _service;

        public AppAutorService(IAutorService service)
        {
            _service = service;
        }

        public void Add(Autor obj)
        {
            _service.Add(obj);
        }

        public IEnumerable<Autor> GetAll()
        {
            return _service.GetAll();
        }

        public Autor GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Remove(Autor obj)
        {
            _service.Remove(obj);
        }

        public void Update(Autor obj)
        {
            _service.Update(obj);
        }
    }
}
