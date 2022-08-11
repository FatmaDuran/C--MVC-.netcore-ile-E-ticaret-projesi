using Eshop.WebUI.Entity;
using Eshop.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Eshop.WebUI.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductRepository
    {
        public EfProductRepository(EshopContext context):base(context)
        {

        }
        public EshopContext EshopContext
        {
            get { return context as EshopContext; }
        }
        public List<Product> GetTop5Products()
        {
           return EshopContext.Products
                .OrderByDescending(i=>i.ProductId)
                .Take(5)
                .ToList();
        }       
    }
}
