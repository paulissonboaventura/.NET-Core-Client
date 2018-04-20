using Core.Domain.Models.Context;
using Core.Domain.Repositories.Abstracts;
using System;
using System.Collections.Generic;

namespace Core.Domain.Repositories.Concrets
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        #region Váriaveis
        protected AgendaContext context;
        #endregion

        #region Construtor
        public RepositoryBase()
        {
            context = new AgendaContext();
        }
        #endregion

        public List<TEntity> GetAll(int pagina = 0, int nrItensPorPagina = 0)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(long key)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void InsertMany(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }
    }
}
