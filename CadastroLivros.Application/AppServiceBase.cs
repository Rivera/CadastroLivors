using CadastroLivros.Application.Interfaces;
using CadastroLivros.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CadastroLivros.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseService<TEntity> _baseService;

        public AppServiceBase()
        {

        }

        public AppServiceBase(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }

        public void Add(TEntity obj)
        {
            _baseService.Add(obj);
        }

        public void Dispose()
        {
            _baseService.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _baseService.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _baseService.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _baseService.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _baseService.Update(obj);
        }
    }
}
