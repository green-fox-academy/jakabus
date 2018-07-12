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

        public RedditService(PostRepository postRepo)
        {
            this.postRepo = postRepo;
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
    }
}
