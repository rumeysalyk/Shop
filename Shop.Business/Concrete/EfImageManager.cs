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
    public class EfImageManager : EfGenericManager<Image>, IImageService
    {
        public EfImageManager(OnlineShopDbContext onlineShopDbContext) : base(onlineShopDbContext)
        {
        }
        public OnlineShopDbContext OnlineShopDbContext
        {
            get { return context as OnlineShopDbContext; }
        }

        public Image GetImageById(int id)
        {
            var image = OnlineShopDbContext.Images.FirstOrDefault(p => p.ImageId == id);
            return image;
        }

        public List<Image> GetImagesByProduct(int id)
        {
            var images = OnlineShopDbContext.Images.Where(p => p.ProductId == id).ToList();
            return images;
        }
    }
}
