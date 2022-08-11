using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.WebUI.Entity;
using Eshop.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;
        private IUnitOfWork unitOfWork;
        public HomeController( IUnitOfWork _unitOfWork,IProductRepository _repository)
        {
            repository = _repository;
            unitOfWork = _unitOfWork;
        }
        public IActionResult Index()
        {


            return View(unitOfWork.products.GetAll().Where(i=>i.IsApproved && i.IsHome).ToList());
        }
        public IActionResult Details(int id)
        {
            return View(repository.Get(id));
        }
        public IActionResult Create()
        {
            var prdct = new Product() { ProductName = "Yeni Ürün", Price = 1000 };
            unitOfWork.products.Add(prdct);
            unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
