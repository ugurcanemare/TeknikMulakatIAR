using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackendProje.Data.Abstract
{
    public interface IGenericRepository<TEntity>
    {

        List<TEntity> GetAll();
    }
}
