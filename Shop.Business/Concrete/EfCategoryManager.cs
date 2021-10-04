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
    public class EfCategoryManager : EfGenericManager<Category>, ICategoryService
    {
        public EfCategoryManager(OnlineShopDbContext onlineShopDbContext) : base(onlineShopDbContext)
        {
        }

        public OnlineShopDbContext OnlineShopDbContext
        {
            get { return context as OnlineShopDbContext; }
        }
        public List<Category> GetTop5Category()
        {
            return OnlineShopDbContext.Categories
                .OrderByDescending(i => i.CategoryId)
                .Take(5)
                .ToList();
        }
    }

}
