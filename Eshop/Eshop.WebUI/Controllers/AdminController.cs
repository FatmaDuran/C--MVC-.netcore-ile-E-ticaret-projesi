using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.WebUI.Entity;
using Eshop.WebUI.Models;
using Eshop.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Eshop.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IUnitOfWork unitOfWork;
        public AdminController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditCategory (int id)
        {
            var entity = unitOfWork.categories.GetAll()
                          .Include(i => i.ProductCategories)
                          .ThenInclude(i => i.Product)
                          .Where(i => i.CategoryId == id)
                          .Select(i => new AdminEditCategoryModel()
                          {
                              CategoryId=i.CategoryId,
                              CategoryName=i.CategoryName,
                             Products=i.ProductCategories.Select(a=>new AdminEditCategoryProduct()
                             {
                                 ProductId=a.ProductId,
                                ProductName=a.Product.ProductName,
                                Image=a.Product.Image,
                                IsApproved=a.Product.IsApproved,
                                IsFutured=a.Product.IsFutured,
                                IsHome=a.Product.IsHome

                          
                             }).ToList()
                             


                          }).FirstOrDefault();
            return View(entity);
        }
        [HttpPost]
        public IActionResult EditCategory(Category entity)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.categories.Edit(entity);
                unitOfWork.SaveChanges();
                return RedirectToAction("CatalogList");
            }
            return View("Error");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveFromCategory(int ProductId, int CategoryId)
        {


            if (ModelState.IsValid)
            {
                //silme
                unitOfWork.categories.RemoveFromCategory(ProductId, CategoryId);
                unitOfWork.SaveChanges();
                return Ok();
            }

            return BadRequest();
        }



        public IActionResult CatalogList()
        {
            var model = new CatalogListModel()
            {
                Categories = unitOfWork.categories.GetAll().ToList(),
                Products = unitOfWork.products.GetAll().ToList()
            };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Category entity)
        {
            if(ModelState.IsValid)
            {
                unitOfWork.categories.Add(entity);
                unitOfWork.SaveChanges();

                return RedirectToAction("CatalogList");
            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product entity, IFormFile file)
        {
            if(ModelState.IsValid)
            {
                if (file != null)
                {
                    var path = Path.Combine (Directory.GetCurrentDirectory(),"wwwroot\\images\\products",file.FileName);
                    var path_tn = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products\\tn", file.FileName);

                    using (var stream=new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        entity.Image = file.FileName;
                    }

                    using (var stream = new FileStream(path_tn, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                       
                    }

                }

                entity.DateAdded = DateTime.Now;

              unitOfWork.products.Add(entity);
                unitOfWork.SaveChanges();
                return RedirectToAction("CatalogList");

            }
            return View(entity);
        }
    }
}
