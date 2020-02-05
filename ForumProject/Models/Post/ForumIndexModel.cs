using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumProject.Models.Post
{
    public class PostIndexModel
    {
        public IEnumerable<PostListingModel> forumList { get; set; }
    }
}
