using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IProductService Products { get; }
        ICategoryService Categories { get; }

        int SaveChanges();
    }
}
