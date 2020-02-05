using ForumProject.Data;
using ForumProject.Data.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task add(Post post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();
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
            return _context.posts.Where(post => post.id == id)
                .Include(post => post.user)
                .Include(post => post.replies).ThenInclude(reply => reply.user)
                .Include(post => post.forum)
                .First();
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
