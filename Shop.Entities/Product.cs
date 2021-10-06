using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities
{
    public class Product
    {
        public Product()
        {
            Images = new List<Image>();
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        /*Category-Product: 1-N Relationship*/
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Image> Images { get; set; }
    }
}
