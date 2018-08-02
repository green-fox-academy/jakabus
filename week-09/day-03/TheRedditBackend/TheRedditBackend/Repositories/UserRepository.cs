using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditBackend.Models;

namespace TheRedditBackend.Repositories
{
    public class UserRepository
    {
        private RedditContext UserDb;

        public UserRepository(RedditContext context)
        {
            this.UserDb = context;
        }

        //CRUD

        public void CreateUser(User user)
        {
            UserDb.Add(user);
            UserDb.SaveChanges();
        }

        public List<User> ReadUsers()
        {
            return UserDb.Users.Include(p => p.Posts).ToList();
        }

        public void UpdateUser(User user)
        {
            UserDb.Update(user);
            UserDb.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            UserDb.Remove(user);
            UserDb.SaveChanges();
        }

        public User GetUserByUserName(string userName)
        {
            return UserDb.Users.Where(p => p.UserName == userName).First();
        }    
    }
}
