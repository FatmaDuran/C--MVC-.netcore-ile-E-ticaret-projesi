  using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Eshop.WebUI.Entity;
using Eshop.WebUI.Models;
using Eshop.WebUI.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Eshop.WebUI.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {

        public EfCategoryRepository(EshopContext context):base (context)
        {

        }
        public EshopContext EshopContext
        {
            get { return context as EshopContext; }
        }

        public IEnumerable<CategoryModel> GetAllWithProductCount()
        {
            return GetAll().Select(i => new CategoryModel()
            {
                CategoryId = i.CategoryId,
                CategoryName = i.CategoryName,
                Count = i.ProductCategories.Count()
        });
        }

        public Category GetByName(string name)
        {
            return EshopContext.Categories
                .Where(i => i.CategoryName == name)
                .FirstOrDefault();
        }

        public void RemoveFromCategory(int ProductId, int CategoryId)
        {
            var cmd = $"delete from ProductCategory where ProductId={ ProductId} and CategoryId={CategoryId}";
            context.Database.ExecuteSqlCommand(cmd);    
        }
    }
}
