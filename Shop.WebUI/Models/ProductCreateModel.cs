using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.WebUI.Models
{
    public class ProductCreateModel
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage="Zorunlu")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Zorunlu")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Zorunlu")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Zorunlu")]
        public int SelectedCategoryId { get; set; }
    }



}
