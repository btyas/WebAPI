using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
  public  interface IUserRepository
    {

        Task<IEnumerable<User>> GetUsersAsync();

        void AddUser(User user);

        void DeleteUser(int userId);

        Task<User> FindUser(int id);
    }
}
