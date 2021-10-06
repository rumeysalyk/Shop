using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebUI.Models
{
    public class ProductImagesModel
    {
        public Product Product { get; set; }
        public List<Image> Images { get; set; }

    }
}
