﻿using CadastroLivros.Application.Interfaces;
using CadastroLivros.Domain.Entities;
using CadastroLivros.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace CadastroLivros.Application
{
    public class AppAutorService : IAppAutorService
    {
        private readonly IBaseRepository<Autor> _repository;

        public AppAutorService(IBaseRepository<Autor> repository)
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
