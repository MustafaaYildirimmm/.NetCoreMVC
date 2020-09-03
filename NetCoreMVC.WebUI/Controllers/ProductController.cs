using Microsoft.AspNetCore.Mvc;
using NetCoreMVC.Business.Abstract;
using NetCoreMVC.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVC.WebUI.Controllers
{
    public class ProductController:Controller
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            var products = _productService.GetAll();
            var model = new ProductListViewModel
            {
                Products = products
            };
            return View(model);
        }
    }
}
