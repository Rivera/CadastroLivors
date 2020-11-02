﻿using CadastroLivros.Application.Interfaces;
using CadastroLivros.Domain.Entities;
using CadastroLivros.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace CadastroLivros.Application
{
    public class AppLivroService : IAppLivroService
    {
        private readonly IBaseRepository<Livro> _repository;

        public AppLivroService(IBaseRepository<Livro> repository)
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
