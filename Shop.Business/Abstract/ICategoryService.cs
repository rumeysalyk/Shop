using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        List<Category> GetTop5Category();
    }
}
