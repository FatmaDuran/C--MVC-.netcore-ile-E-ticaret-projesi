using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository repository;

        public CategoryController(ICategoryRepository _repository)
        {
            repository = _repository;
        }
        
        public IActionResult Index()
        {
            var cat = repository.GetByName("Electronics");
            return View(cat);
        }
    }
}
