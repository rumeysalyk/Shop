using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Business.Abstract;
using Shop.Entities;
using Shop.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IUnitOfWork unitOfWork;
        private readonly IMapper mapper; // AutoMapper

        public ProductController(IUnitOfWork _unitOfWork,IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
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
            
            ViewBag.AllCategories = new SelectList(unitOfWork.Categories.GetAll(), "CategoryId", "CategoryName");

            var emptyViewModel = new ProductCreateModel();
            return View(emptyViewModel);
        }

        [HttpPost]
        public IActionResult Create(ProductCreateModel model)
        {
            /* add new product */

            if (ModelState.IsValid)
            {
                Product product = mapper.Map<Product>(model);

                unitOfWork.Products.Add(product);
                unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.AllCategories = new SelectList(unitOfWork.Categories.GetAll(), "CategoryId", "CategoryName");

                return View(model);
            }
            

        }

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    return View(unitOfWork.Products.Get(id));
        //}

        //[HttpPost, ActionName("Delete")]
        //public IActionResult Deleted(Product product)
        //{
        //    unitOfWork.Products.Delete(product);
        //    unitOfWork.SaveChanges();
        //    TempData["message"] = "Deleted";
        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    return View(unitOfWork.Products.Get(id));
        //}

        //[HttpPost]
        //public IActionResult Edit(Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        unitOfWork.Products.Edit(product);
        //        unitOfWork.SaveChanges();

        //        TempData["message"] = $"{ product.ProductName} is updated.";
        //        return RedirectToAction("Index");
        //    }
        //    return View(product);
        //}

    }
}
