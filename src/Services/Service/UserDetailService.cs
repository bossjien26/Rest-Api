using System.Threading.Tasks;
using DbEntity;
using Entities;
using Repositories.IRepository;
using Repositories.Repository;
using Services.IService;
using src.Repositories.IRepository;
using src.Repositories.Repository;

namespace Services.Service
{
    public class UserDetailService : IUserDetailService
    {
        private IUserDetailRepository _repository;

        public UserDetailService(DbContextEntity dbContextEntity)
        {
            _repository = new UserDetailRepository(dbContextEntity);
        }

        public async Task Insert(UserDetail instance) => await _repository.Insert(instance);
    }
}