using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditBackend.Models;
using TheRedditBackend.Repositories;

namespace TheRedditBackend.Services
{
    public class RedditService
    {
        private PostRepository postRepo;
        private UserRepository userRepo;

        public RedditService(PostRepository postRepo, UserRepository userRepo)
        {
            this.postRepo = postRepo;
            this.userRepo = userRepo;
        }

        public void AddPost(Post post)
        {
            postRepo.Create(post);
        }

        public List<Post> GetPosts()
        {
            return postRepo.ReadPosts();
        }

        public void EditPost(Post post)
        {
            postRepo.Update(post);
        }

        public void DeletePost(Post post)
        {
            postRepo.Delete(post);
        }

        public string Login(string userName, string password)
        {
            return userRepo.GetUserByUserName(userName).Password == password ? "wall" : "/";
        }
    }
}
