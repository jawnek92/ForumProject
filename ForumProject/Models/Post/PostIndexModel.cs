using ForumProject.Models.Reply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumProject.Models.Post
{
    public class PostIndexModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string authorId { get; set; }
        public string authorName { get; set; }
        public string authorImageUrl { get; set; }
        public int authorRathing { get; set; }
        public DateTime created { get; set; }
        public string content { get; set; }
        public int forumId { get; set; }
        public string forumName { get; set; }
        public bool isAuthorAdmin { get; set; }
        public IEnumerable<PostReplyModel> replies { get; set; }

    }
}
