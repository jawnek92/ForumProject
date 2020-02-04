using ForumProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForumProject.Data
{
    public interface IForum
    {
        Forum getById(int id);
        IEnumerable<Forum> getAll();
        IEnumerable<ApplicationUser> getAllActiveUsers();

        Task create(Forum forum);
        Task delete(Forum forum);
        Task updateForumTitle(int forumId, string newTitle);
        Task updateForumDescription(int forumId, string newDescription);
    }
}
