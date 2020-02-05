using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumProject.Models.Post
{
    public class NewPostModel
    {
        public string forumName { get; set; }
        public int forumId { get; set; }
        public string authorName { get; set; }
        public string forumImageUrl { get; set; }
        public string title { get; set; }
        public string content { get; set; }
    }
}
