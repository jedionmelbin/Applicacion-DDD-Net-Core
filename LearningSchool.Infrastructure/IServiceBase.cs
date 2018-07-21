using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningSchool.Infrastructure
{
    public interface IServiceBase<TEntity>
    {
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
