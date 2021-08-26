using DbEntity;
using Entities;
using Repositories.IRepository;

namespace Repositories.Repository
{
    public class UserRepository : GenericRepository<User> , IUserRepository
    {
        public UserRepository(DbContextEntity context):base(context)
        {
            
        }
    }
}