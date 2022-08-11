using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.WebUI.Repository.Abstract
{
   public interface IUnitOfWork:IDisposable
    {
        IProductRepository products { get; }
        ICategoryRepository categories { get; }

        int SaveChanges();
    }
}
