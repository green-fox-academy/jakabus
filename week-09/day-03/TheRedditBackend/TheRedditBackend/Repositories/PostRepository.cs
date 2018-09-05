using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditBackend.Models;

namespace TheRedditBackend.Repositories
{
    public class PostRepository
    {
        private RedditContext postsDb;

        public PostRepository(RedditContext postsDb)
        {
            this.postsDb = postsDb;
        }
        
        //CRUD

        public void Create(Post post)
        {
            postsDb.Add(post);
            postsDb.SaveChanges();
        }

        public List<Post> ReadPosts()
        {
            return postsDb.Posts.ToList();
        }

        public void Update(Post post)
        {
            postsDb.Posts.Update(post);
            postsDb.SaveChanges();
        }
        public void Delete(Post post)
        {
            postsDb.Posts.Remove(post);
            postsDb.SaveChanges();
        }
    }
}
