using System.Threading.Tasks;
using DbEntity;
using Entities;
using Repositories.IRepository;
using Repositories.Repository;
using Services.IService;

namespace Services.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(DbContextEntity contextEntity)
        {
            _repository = new CategoryRepository(contextEntity);
        }

        public CategoryService(ICategoryRepository genericRepository)
            => _repository = genericRepository;

        public async Task Insert(Category instance)
            => await _repository.Insert(instance);

        public async Task<Category> GetById(int Id)
        {
            return await _repository.Get(x => x.Id == Id);
        }
    }
}