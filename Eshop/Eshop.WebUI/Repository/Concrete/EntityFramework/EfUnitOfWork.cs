using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.WebUI.Repository.Abstract;

namespace Eshop.WebUI.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly EshopContext dbContext;
        public EfUnitOfWork(EshopContext _dbContext)
        {
            dbContext = _dbContext?? throw new ArgumentNullException ("dbcontext null olamaz");
        }

        private IProductRepository _products;
        private ICategoryRepository _categories;
        public IProductRepository products
        {
            get
            {
                return _products ?? (_products = new EfProductRepository(dbContext));
            }
        }

        public ICategoryRepository categories
        {
            get
            {
                return _categories ?? (_categories=new EfCategoryRepository(dbContext));
            }
        }

      public int SaveChanges()
        {
           try
            {
               return dbContext.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }

       
    }
}
