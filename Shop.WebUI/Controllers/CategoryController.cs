using Microsoft.AspNetCore.Mvc;
using Shop.Business.Abstract;
using Shop.Entities;
using Shop.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private IUnitOfWork unitOfWork;

        public CategoryController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Index()
        {
            var model = new CatalogListModel()
            {
                Categories = unitOfWork.Categories.GetAll().ToList(),
                Products = unitOfWork.Products.GetAll().ToList()
            };

            return View(model);    
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Categories.Add(category);
                unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);

        }
    }
}
