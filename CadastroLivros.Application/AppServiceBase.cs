using CadastroLivros.Application.Interfaces;
using CadastroLivros.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CadastroLivros.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseService<TEntity> _baseService;

        public void Add(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
