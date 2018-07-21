using LearningSchool.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSchool.Infrastructure
{
    public class GenericRepository<TEntity> : IDisposable, IGenericRepository<TEntity> where TEntity : class
    {
        protected ApplicationDbContext _applicationDbContext;
        protected DbSet<TEntity> _DbSet;
        private bool disposed = false;

        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            this._DbSet = applicationDbContext.Set<TEntity>();
        }

        public async Task Insert(TEntity entity)
        {
            try
            {
                _applicationDbContext.Set<TEntity>().Add(entity);
                await _applicationDbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Insert(List<TEntity> entityList)
        {
            try
            {
                _applicationDbContext.Set<TEntity>().AddRange(entityList);
                await _applicationDbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task Update(TEntity entity)
        {
            try
            {

                _applicationDbContext.Update(entity);
                await _applicationDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TEntity GetById(int id)
        {
            var query = _applicationDbContext.Set<TEntity>().Find(id);
            return query;
        }
        public Task Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {

                var query = _applicationDbContext.Set<TEntity>().ToList();
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _applicationDbContext.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
