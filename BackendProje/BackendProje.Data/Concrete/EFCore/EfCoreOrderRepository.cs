using BackendProje.Data.Abstract;
using BackendProje.Data.Concrete.EFCore.Context;
using BackendProje.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProje.Data.Concrete.EFCore
{
    public class EfCoreOrderRepository : EfCoreGenericRepository<Order> , IOrderRepository
    {
        public EfCoreOrderRepository(BackEndContext _appContext) : base(_appContext)
        {
        }
        BackEndContext AppContext
        {
            get { return _dbContext as BackEndContext; }
        }
    }
}
