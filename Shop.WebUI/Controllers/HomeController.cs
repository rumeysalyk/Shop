using Microsoft.AspNetCore.Mvc;
using Shop.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService productService;

        public HomeController(IProductService _productService)
        {
            productService = _productService;
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(productService.GetAll());

            }
            else
            {
                var condition = productService.GetAll().Where(i => i.CategoryId == id);
                return View(condition);
            }
        }



    }
}
