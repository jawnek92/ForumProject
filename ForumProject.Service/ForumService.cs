using ForumProject.Data;
using ForumProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumProject.Service
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _context;
        public ForumService(ApplicationDbContext context)
        {
            this._context = context;
        }
        public Task create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task delete(Forum forum)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> getAll()
        {
            return _context.forums.Include(forum => forum.posts);
        }

        public IEnumerable<ApplicationUser> getAllActiveUsers()
        {
            throw new NotImplementedException();
        }

        public Forum getById(int id)
        {
            var forum = _context.forums.Where(tempForum => tempForum.id == id)
                .Include(tempForum => tempForum.posts).ThenInclude(posts => posts.user)
                .Include(tempForum => tempForum.posts).ThenInclude(posts => posts.replies).ThenInclude(reply => reply.user)
                .FirstOrDefault();
            return forum;
        }

        public Task updateForumDescription(int forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task updateForumTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}
