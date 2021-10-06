using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface IImageService : IGenericService<Image>
    {
        List<Image> GetImagesByProduct(int id);
        Image GetImageById(int id);
    }
}
