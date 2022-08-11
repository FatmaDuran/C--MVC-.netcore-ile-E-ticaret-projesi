﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.WebUI.Component
{
    public class FeaturedProducts : ViewComponent
    {
        private IProductRepository repository;
        public FeaturedProducts(IProductRepository _repository)
        {
            repository = _repository;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository
                .GetAll()
                .Where(i => i.IsApproved && i.IsFutured)
                .ToList());
        }
    }
}

