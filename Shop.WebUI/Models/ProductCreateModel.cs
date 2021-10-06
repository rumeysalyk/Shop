using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.WebUI.Models
{
    public class ProductCreateModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int SelectedCategoryId { get; set; }
    }



}
