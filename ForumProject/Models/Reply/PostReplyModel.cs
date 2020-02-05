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
        public string content { get; set; }

        public IEnumerable<PostReplyModel> replies { get; set; }

    }
}
