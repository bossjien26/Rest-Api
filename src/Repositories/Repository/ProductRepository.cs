using DbEntity;
using Entities;
using Repositories.IRepository;

namespace Repositories.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContextEntity context) : base(context)
        {

        }
    }
}