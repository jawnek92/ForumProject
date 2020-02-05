using ForumProject.Data;
using ForumProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProject.Service
{
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _context;

        public PostService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public Task add(Post post)
        {
            throw new NotImplementedException();
        }

        public Task delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task editPost(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> getAll()
        {
            throw new NotImplementedException();
        }

        public Post getById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> getFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> getPostsByForum(int id)
        {
            var posts = _context.forums.Where(forum => forum.id == id).First().posts;
            return posts;
        }
    }
}
