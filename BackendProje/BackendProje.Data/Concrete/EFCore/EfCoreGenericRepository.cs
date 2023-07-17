using BackendProje.Data.Abstract;
using BackendProje.Data.Concrete.EFCore.Context;
using BackendProje.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackendProje.Data.Concrete.EFCore
{
    public class EfCoreGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IBaseEntity
    {
        protected readonly BackEndContext _dbContext;

        public EfCoreGenericRepository(BackEndContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().Where(x => x.Status == true).ToList();
        }
    }
}
