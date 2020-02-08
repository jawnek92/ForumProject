using ForumProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumProject.Data
{
    public interface IPost
    {
        Post getById(int id);
        IEnumerable<Post> getAll();
        IEnumerable<Post> getFilteredPosts(Forum forum, string searchQuery);
        IEnumerable<Post> getPostsByForum(int id);
        IEnumerable<Post> getLatestPosts(int number);

        Task add(Post post);
        Task delete(int id);
        Task editPost(int id, string newContent);
        Task addReply(PostReply postReply);
        
    }
}
