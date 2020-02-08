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

        public async Task addReply(PostReply postReply)
        {
            _context.replies.Add(postReply);
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
            return _context.posts
                .Include(post => post.user)
                .Include(post => post.replies).ThenInclude(reply => reply.user)
                .Include(post => post.forum);
        }

        public Post getById(int id)
        {
            return _context.posts.Where(post => post.id == id)
                .Include(post => post.user)
                .Include(post => post.replies).ThenInclude(reply => reply.user)
                .Include(post => post.forum)
                .First();
        }

        public IEnumerable<Post> getFilteredPosts(Forum forum, string searchQuery)
        {
            return string.IsNullOrEmpty(searchQuery) ? forum.posts : 
                forum.posts.Where(p => p.title.Contains(searchQuery) || p.content.Contains(searchQuery));
        }

        public IEnumerable<Post> getLatestPosts(int number)
        {
            return getAll().OrderByDescending(post => post.created).Take(number);
        }

        public IEnumerable<Post> getPostsByForum(int id)
        {
            var posts = _context.forums.Where(forum => forum.id == id).First().posts;
            return posts;
        }
    }
}
