using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Data.Repo
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext dc;

        public UserRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddUser(User user)
        {
            dc.Users.Add(user);
        }

        public void DeleteUser(int userId)
        {
            var user = dc.Users.Find(userId);
            dc.Users.Remove(user);

        }

        public async Task<User> FindUser(int id)
        {
            return await dc.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await dc.Users.ToListAsync();
        }
    }
}
