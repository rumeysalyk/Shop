using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities
{
    public class Image
    {
        public int ImageId { get; set; }

        public string ImageURL { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
