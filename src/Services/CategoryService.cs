using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbEntity;
using Entities;
using Repositories.Interface;
using Repositories;
using Services.Interface;

namespace Services
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

        public async Task<Category> GetById(int id)
        {
            return await _repository.Get(x => x.Id == id);
        }

        public IEnumerable<Category> GetMany(int index, int size)
        {
            return _repository.GetAll()
                .Skip((index - 1) * size)
                .Take(size)
                .OrderByDescending(x => x.Id);
        }
    }
}