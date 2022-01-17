using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;
using StackExchange.Redis;

namespace Services.Interface
{
    public interface IUserService
    {
        Task Insert(User instance);

        void Update(User instance);

        IEnumerable<User> GetAll();

        IEnumerable<User> GetMany(int index, int size);

        Task<User> GetById(int userId);

        User GetVerifyUser(string mail, string password);

        User SearchUserMail(string mail);

        Task Login(string token, string userId);

        Task UserExpireDateTime(string token, DateTime dateTime);

        Task Logout(string token);

        Task<RedisValue> GetRedisUserId(string token);
    }
}