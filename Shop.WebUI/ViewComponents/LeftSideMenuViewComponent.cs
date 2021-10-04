using Microsoft.AspNetCore.Mvc;
using Shop.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebUI.ViewComponents
{
    public class LeftSideMenuViewComponent : ViewComponent
    {
        private IUnitOfWork unitOfWork;

        public LeftSideMenuViewComponent(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public IViewComponentResult Invoke()
        {
            return View(unitOfWork.Categories.GetAll());
        }
    }
}
