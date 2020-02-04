using System;
using System.Collections.Generic;
using System.Text;

namespace ForumProject.Data.Models
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime created { get; set; }
        public virtual ApplicationUser user { get; set; }
        public virtual Forum forum { get; set; }

        public virtual IEnumerable<PostReply> replies { get; set; }
    }
}
