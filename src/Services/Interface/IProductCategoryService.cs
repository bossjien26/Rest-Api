using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace Services.Interface
{
    public interface IProductCategoryService
    {
         Task Insert(ProductCategory instance);

        Task<ProductCategory> GetById(int id);
        
        IEnumerable<ProductCategory> GetMany(int index, int size);
    }
}