using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumProject.Models.Reply
{
    public class PostReplyModel
    {
        public int id { get; set; }
        public string authorId { get; set; }
        public string authorName { get; set; }
        public string authorImageUrl { get; set; }
        public int authorRating { get; set; }

        public DateTime created { get; set; }
        public string replyContent { get; set; }
        
        public int postId { get; set; }
        public string postTitle { get; set; }
        public string postContent { get; set; }
        
        public string forumName { get; set; }
        public string forumImageUrl { get; set; }
        public int forumId { get; set; }

    }
}
