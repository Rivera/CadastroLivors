using CadastroLivros.Domain.Interfaces.Repositories;
using CadastroLivros.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CadastroLivros.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected CadastroLivrosContext Db = new CadastroLivrosContext();

        public void Add(TEntity obj)
        {
            try
            {
                Db.Set<TEntity>().Add(obj);
                Db.SaveChanges();
            }
            catch(ArgumentException ex)
            {
                throw new ArgumentException("Não foi possível adicionar o registro: " + ex.Message);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return Db.Set<TEntity>().ToList();
            }
            catch(ArgumentException ex)
            {
                throw new ArgumentException("Não foi possível recuperar os dados solicitados: " + ex.Message);
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                return Db.Set<TEntity>().Find(id);
            }
            catch(ArgumentException ex)
            {
                throw new ArgumentException("Não foi possível recuperar o dado solitado: " + ex.Message);
            }
        }

        public void Remove(TEntity obj)
        {
            try
            {
                Db.Set<TEntity>().Remove(obj);
                Db.SaveChanges();
            }
            catch(ArgumentException ex)
            {
                throw new ArgumentException("Não foi possível excluir o registro: " + ex.Message);
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                Db.Entry(obj).State = EntityState.Modified;
                Db.SaveChanges();
            }
            catch(ArgumentException ex)
            {
                throw new ArgumentException("Não foi possível atualizar o registro: " + ex.Message);
            }
        }
    }
}
