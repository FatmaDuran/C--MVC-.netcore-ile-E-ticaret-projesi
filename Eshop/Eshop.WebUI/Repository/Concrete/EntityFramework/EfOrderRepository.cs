using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Eshop.WebUI.Entity;
using Eshop.WebUI.Repository.Abstract;

namespace Eshop.WebUI.Repository.Concrete.EntityFramework
{
    public class EfOrderRepository : IOrderRepository
    {
        private EshopContext context;
        public EfOrderRepository(EshopContext ctx)
            {
            context = ctx;
            }

        public void Add(Order entity)
        {
            context.Add(entity);
        }

        public void Delete(Order entity)
        {
            context.Orders.Remove(entity);
        }

        public void Edit(Order entity)
        {
            context.Entry<Order>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IQueryable<Order> Find(Expression<Func<Order, bool>> predicate)
        {
            return context.Orders.Where(predicate);
        }

        public Order Get(int id)
        {
            return context.Orders.FirstOrDefault(i => i.OrderId == id);
        }

        public IQueryable<Order> GetAll()
        {
            return context.Orders;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
