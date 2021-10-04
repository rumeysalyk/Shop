using Shop.Business.Abstract;
using Shop.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Concrete
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly OnlineShopDbContext onlineShopDbContext;

        public EfUnitOfWork(OnlineShopDbContext onlineShopDbContext)
        {
            this.onlineShopDbContext = onlineShopDbContext ?? throw new ArgumentNullException("DbContext cannot be null");
        }


        private IProductService _products;
        private ICategoryService _categories;

        public IProductService Products
        {
            get
            {
                return _products ?? (_products = new EfProductManager(onlineShopDbContext));
            }
        }

        public ICategoryService Categories
        {
            get
            {
                return _categories ?? (_categories = new EfCategoryManager(onlineShopDbContext));
            }
        }


        public void Dispose()
        {
            onlineShopDbContext.Dispose();
        }

        public int SaveChanges()
        {
            try
            {
                return onlineShopDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
