using Shop.Business.Abstract;
using Shop.DataAccess.EntityFramework;
using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Concrete
{
    public class EfProductManager : EfGenericManager<Product>, IProductService
    {
        public EfProductManager(OnlineShopDbContext onlineShopDbContext) : base(onlineShopDbContext)
        {
        }

        /*look at this part again*/
        public OnlineShopDbContext OnlineShopDbContext
        {
            get { return context as OnlineShopDbContext; }
        }

        public List<Product> GetTop5Product()
        {
            return OnlineShopDbContext.Products
                .OrderByDescending(i => i.ProductId)
                .Take(6)
                .ToList();
        }
    }
}
